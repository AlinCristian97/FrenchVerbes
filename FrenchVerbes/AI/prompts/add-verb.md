# Add a French Verb

Use this checklist every time a verb is added.

## 0) Interpreting "add next X" requests

If the user says **"add next X"** (e.g. "add next 5"), interpret it as:
1. Open the current-group constants letter file (e.g. `Constants.Verbs.Regular.Er.A.cs`).
2. Find the line marked `// <-- you are here`.
3. Take the **next X verb constants** that appear **after** that line in the file.
4. Apply the full add-verb checklist (steps 1–6) to each of those X verbs in order.
5. After completing all X verbs, the `// <-- you are here` marker must sit on the **last** verb added.

## 1) Verify the verb constant first

1. Identify the target group (`Irregular`, `Regular.Er`, `Regular.Ir`, `Regular.Re`).
2. Open the appropriate constants letter file in:
   - `FrenchVerbes/AllConstants/AllVerbs/...`
3. Confirm the verb constant is not duplicated.
4. If missing, add it in the correct letter file.
   - **⚠️ C# identifiers (constant names, method names) must never contain accented characters.** Strip accents from the identifier only: `é → e`, `è → e`, `ê → e`, `à → a`, `â → a`, `ô → o`, `î → i`, `û → u`, etc. The constant *value* string keeps the correct French spelling. Example: `public const string Contracter = "contracter";` — **not** `Contractér`.
5. After adding the verb implementation, append a `// <-- you are here` comment in its appropriate Constants file on the same line (e.g., `public const string Accrocher = "accrocher"; // <-- you are here`).

## 2) Add the verb description constant

1. Open the matching description letter file in:
   - `FrenchVerbes/AllConstants/AllVerbDescriptions/...`
2. Add `public const string <VerbName> = "...";` in the correct letter file.
3. Keep naming aligned with the verb constant.
4. The description **must be written in French** and follow this exact pattern:
   - Start with the infinitive (with accents): `"<Infinitive> signifie ..."`
   - Explain the meaning in French using a full sentence.
   - End with the group classification sentence, e.g.: `"C'est un verbe régulier du premier groupe en -er."`
   - For reflexive verbs, end with: `"C'est un verbe pronominal régulier du premier groupe en -er."`
   - Example: `public const string Envisager = "Envisager signifie considérer quelque chose comme possible ou probable, imaginer une situation future ou envisager une possibilité. C'est un verbe régulier du premier groupe en -er.";`
   - **Never** use an English translation as the description value (e.g. `"To anger, to annoy"` is wrong).

## 3) Register the verb in repository

1. Open the matching repository letter file in:
   - `FrenchVerbes/Verbes/AllVerbesRepository/...`
2. Add the verb in the corresponding `Add...{Letter}Verbs()` method.
3. Add a `Create<VerbName>()` factory method in the same file.
4. Wire it using:
   - `Constants.Verbs....<VerbName>`
   - `Constants.VerbDescriptions....<VerbName>`
5. Optionally pass a `tensesNotes: new NotesObject { ... }` if the verb has conjugation notes worth highlighting (e.g. stem changes, spelling exceptions, auxiliary reminders). Leave it out if no notes are needed.
6. **If the verb is reflexive** (e.g. `s'axer`), pass:
   - `usesEtre: true` — reflexive verbs always use être in compound tenses
   - `isReflexive: true` — enables correct reflexive pronoun injection across all tenses
   - **Also** update the factory of the base non-reflexive verb (e.g. `axer`) to pass `hasReflexive: true` as a hint to the learner.
7. **If the verb has a reflexive counterpart** but is not itself reflexive, pass `hasReflexive: true`.
8. Keep implementation style consistent with existing verbs in that file.

## 4) Regular ER special stem rules (only if needed)

1. If the verb is `Regular.Er`, check whether it needs a custom stem rule (spelling/conjugation exceptions).
2. **Important:** Verbs ending in `-cer` (e.g. `annoncer`, `avancer`) and `-ger` (e.g. `arranger`, `manger`) are **already handled generically** by `RegularErVerb.cs` (`GetAdjustedStem` method). Do **not** create a custom stem rule for these verbs.
3. If needed for other cases, create/update the rule class in:
   - `FrenchVerbes/Verbes/Regular/StemRules/Er/<Letter>/`
4. Register the rule in the matching letter registry file:
   - `RegularErStemRules<Letter>.cs`
5. Ensure it is included by `BuildSpecialStemRules` composition in `RegularErVerb`.
6. If no special behavior is needed, do not add a custom rule.

## 5) Add example sentences JSON

1. Add a file in the proper folder structure under:
   - `FrenchVerbes/Sentences/IrregularVerbes/{LETTER}/` for irregular verbs
   - `FrenchVerbes/Sentences/RegularVerbes/Er/{LETTER}/` for Regular.Er verbs
   - `FrenchVerbes/Sentences/RegularVerbes/Ir/{LETTER}/` for Regular.Ir verbs
   - `FrenchVerbes/Sentences/RegularVerbes/Re/{LETTER}/` for Regular.Re verbs
   - Where `{LETTER}` is the **first letter of the infinitive** (uppercase).
   - **For reflexive verbs**, the deciding letter ignores the `se/s'` prefix. E.g. `s'axer` → letter is `A`.
   - **If the letter folder does not exist, create it**.
2. File name must be derived from the **constant's value string** (i.e. the actual French infinitive with accents), lowercased, using underscores instead of spaces. **Never use the C# identifier (which strips accents) as the file name.** For example: the constant `public const string Debloquer = "débloquer";` produces the file `débloquer.json`, **not** `debloquer.json`. Reflexive verbs with `se` must use `se_` prefix with an underscore (e.g. `se_débloquer.json`, `se_lever.json`). **Never use spaces in JSON file names**.
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
6. **For reflexive verbs**, sentences must use correct reflexive pronoun conjugation:
   - Présent/Imparfait/Futur/Conditionnel: `je me/tu te/il se/nous nous/vous vous/ils se` + conjugated base verb
   - Passé Composé: `je me suis/tu t'es/il s'est/...` + past participle of the **base verb** (not `s'axé` — just `axé`)
   - Futur Proche: `je vais me/tu vas te/...` + base infinitive
   - Passé Récent: `je viens de me/tu viens de te/...` + base infinitive (no contraction of `de` before the pronoun)
   - Impératif: `axe-toi / axons-nous / axez-vous`

## 6) Validation

1. Build the solution.
2. Ensure no duplicate constants or duplicate methods were introduced.
3. Ensure repository references compile and the new verb is discoverable.

## Notes

- Follow letter-based file partitioning already used in the project.
- Do not add duplicate verb constants.
- Keep method/class naming conventions exactly aligned with existing code.
- Keep json files to 5 sentences per tense
- **For reflexive verbs**, the constant name uses the `Se_` prefix (e.g. `Se_Axer`), and the constant value is the full reflexive infinitive (e.g. `"s'axer"` or `"se lever"`).
- **Do not replace spaces with underscores in verb constants** (for example keep `"se lever"` in constant values). Underscores are only for JSON filenames (e.g. `se_lever.json`).
- **Reflexive verbs always use être** as their auxiliary in compound tenses — always pass `usesEtre: true`.
- The `BareInfinitive` (base verb without `se/s'`) is computed automatically by the engine — do not manually strip it anywhere.
- When adding a reflexive verb, also go back and add `hasReflexive: true` to the factory of its base verb if that verb already exists in the repository.
- **C# constant names and method names must not contain accented characters.** When a verb's infinitive contains accented letters (e.g. `considérer`, `céder`), strip the accents only in the C# identifier for that verb: replace each accented letter with its unaccented equivalent (e.g. `é → e`, `è → e`, `ô → o`, etc.). The **constant value string** keeps the correct French spelling (e.g. `public const string Considerer = "considérer";`). Apply this rule only to the specific verb being added, not as a blanket rename of existing identifiers.
