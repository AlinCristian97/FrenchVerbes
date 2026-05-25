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
5. Keep implementation style consistent with existing verbs in that file.

## 4) Add example sentences JSON

1. Add a file in the proper folder under:
   - `FrenchVerbes/Sentences/...`
2. File name must be lowercased infinitive (for example: `atteler.json`).
3. Include exactly these tenses:
   - `Présent`
   - `Imparfait`
   - `Futur Simple`
   - `Passé Composé`
   - `Futur Proche`
   - `Passé Récent`
   - `Impératif`
   - `Conditionnel Présent`
4. Add **5 sentences per tense**.

## 5) Validation

1. Build the solution.
2. Ensure no duplicate constants or duplicate methods were introduced.
3. Ensure repository references compile and the new verb is discoverable.

## Notes

- Follow letter-based file partitioning already used in the project.
- Do not add duplicate verb constants.
- Keep method/class naming conventions exactly aligned with existing code.
- Keep json files to 5 sentences per tense
