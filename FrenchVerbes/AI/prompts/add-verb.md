# Add a French Verb

Use this checklist every time a verb is added.

## 1) Verify the verb constant first

1. Identify the target group (`Irregular`, `Regular.Er`, `Regular.Ir`, `Regular.Re`).
2. Open the appropriate constants letter file in:
   - `FrenchVerbes/AllConstants/AllVerbs/...`
3. Confirm the verb constant is not duplicated.
4. If missing, add it in the correct letter file.

## 2) Add the verb description constant

1. Open the matching description letter file in:
   - `FrenchVerbes/AllConstants/AllVerbDescriptions/...`
2. Add `public const string <VerbName> = "...";` in the correct letter file.
3. Keep naming aligned with the verb constant.

## 3) Register the verb in repository

1. Open the matching repository letter file in:
   - `FrenchVerbes/Verbes/AllVerbesRepository/...`
2. Add the verb in the corresponding `Add...{Letter}Verbs()` method.
3. Add a `Create<VerbName>()` factory method in the same file.
4. Wire it using:
   - `Constants.Verbs....<VerbName>`
   - `Constants.VerbDescriptions....<VerbName>`
5. Optionally pass a `tensesNotes: new NotesObject { ... }` if the verb has conjugation notes worth highlighting (e.g. stem changes, spelling exceptions, auxiliary reminders). Leave it out if no notes are needed.
6. Keep implementation style consistent with existing verbs in that file.

## 4) Regular ER special stem rules (only if needed)

1. If the verb is `Regular.Er`, check whether it needs a custom stem rule (spelling/conjugation exceptions).
2. If needed, create/update the rule class in:
   - `FrenchVerbes/Verbes/Regular/StemRules/Er/<Letter>/`
3. Register the rule in the matching letter registry file:
   - `RegularErStemRules<Letter>.cs`
4. Ensure it is included by `BuildSpecialStemRules` composition in `RegularErVerb`.
5. If no special behavior is needed, do not add a custom rule.

## 5) Add example sentences JSON

1. Add a file in the proper folder structure under:
   - `FrenchVerbes/Sentences/IrregularVerbes/{LETTER}/` for irregular verbs
   - `FrenchVerbes/Sentences/RegularVerbes/Er/{LETTER}/` for Regular.Er verbs
   - `FrenchVerbes/Sentences/RegularVerbes/Ir/{LETTER}/` for Regular.Ir verbs
   - `FrenchVerbes/Sentences/RegularVerbes/Re/{LETTER}/` for Regular.Re verbs
   - Where `{LETTER}` is the **first letter of the infinitive** (uppercase).
   - **If the letter folder does not exist, create it**.
2. File name must be lowercased infinitive (for example: `atteler.json`).
3. Include exactly these tenses as keys, with no other fields:
   - `Présent`
   - `Imparfait`
   - `Futur Simple`
   - `Passé Composé`
   - `Futur Proche`
   - `Passé Récent`
   - `Impératif`
   - `Conditionnel Présent`
4. Add **5 sentences per tense**.
5. The JSON structure must contain **only tense keys** — do not add a "verb" field or any other metadata.

## 6) Validation

1. Build the solution.
2. Ensure no duplicate constants or duplicate methods were introduced.
3. Ensure repository references compile and the new verb is discoverable.

## Notes

- Follow letter-based file partitioning already used in the project.
- Do not add duplicate verb constants.
- Keep method/class naming conventions exactly aligned with existing code.
- Keep json files to 5 sentences per tense
