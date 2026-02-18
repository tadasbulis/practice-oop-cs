## Lab 1

**Vardas Pavardė:** Edgaras Mitkus
**Grupė:** PS-5
**Paskaitos data:** 2026-02-14
**Random užduotis:** 5
**Fallback (jei #5 per sunki):** 3

### Paleidimas
dotnet run -- --challenge

### Kas įgyvendinta
**Užduotis #3: Konsolinis meniu**
- Sukurtos `Student` ir `Group` klasės pagal OOP principus
- Pilnas konsolinis meniu (1 - Pridėti, 2 - Rodyti, 0 - Išeiti)
- Dinaminis studentų sąrašas (`List<Student>`)

**Užduotis #5: Validacija + Refactoring + OOP**
- **Live validacija** įvedant naują studentą:
  - ID (tik skaičius)
  - Vardas (tik raidės, negali būti tuščias)
  - El. paštas (turi turėti `@` ir `.`)
  - Vidurkis (nuo 0 iki 10)
- **Pilnas refactoring** pagal OOP principus:
  - `private` laukai + `readonly` (tikras užkapsuliavimas)
  - Konstruktoriai vietoj viešų properties
  - Metodai `GetInfo()` ir `GetVidurkis()` Student klasėje
  - Grupės bendro vidurkio skaičiavimas (`private` metodas Group klasėje)
  - Group klasė nieko nežino apie Student vidų (tik per viešus metodus)
- `TaskGenerator` klasė atsitiktinei užduočiai generuoti

### Struktūra
- `Program.cs` – pagrindinis programos ciklas ir meniu (koordinavimas)
- `Student.cs` – studento klasė (privatūs laukai, konstruktorius, `GetInfo()`, `GetVidurkis()`)
- `Group.cs` – grupės klasė (privatūs laukai, konstruktorius, validacija, vidurkio skaičiavimas)
- `Group.cs` – grupės klasė (privatūs laukai, konstruktorius, validacija, vidurkio skaičiavimas)
- `TaskGenerator.cs` – atsitiktinės užduoties generavimas