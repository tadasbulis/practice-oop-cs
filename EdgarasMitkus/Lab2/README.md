# 📚 Lab2 – Bibliotekos valdymo sistema

> Konsоlinė C# programa bibliotekos knygoms valdyti pagal OOP principus

## Apie projektą

Programa leidžia valdyti bibliotekos knygas – pridėti, peržiūrėti, skolintis ir grąžinti. Sukurta pagal **Model / Service / Program** architektūrą.

## Paleidimas
```
dotnet run
```

## Funkcionalumas

- ➕ Pridėti knygą (pavadinimas, autorius, metai)
- 📋 Rodyti visas knygas su statusu
- 📖 Pasiskolinti knygą
- 🔄 Grąžinti knygą

## Architektūra
```
Lab2/
├── Program.cs              – UI (Console, meniu, validacija)
├── Models/
│   ├── Book.cs             – Knygos duomenys + statusas
│   └── Library.cs          – Bibliotekos duomenys
└── Services/
    └── LibraryService.cs   – Veiksmai (pridėti, skolinti, grąžinti)
```


## Autorius

**Edgaras Mitkus** – PS-5 – 2026