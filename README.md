## 🌐 Jazyk / Language Selection

*Klikněte na sekci níže pro zobrazení v češtině nebo angličtině.*
*Click on a section below to toggle between Czech and English.*

---

<details open>
<summary>🇨🇿 <strong>ČEŠTINA (Czech Version)</strong></summary>

# Losovač – WinForms aplikace v C#

Losovač je jednoduchá WinForms aplikace vytvořená pro losování výherců ze seznamu soutěžících (vytvořená pro Junior Guru komunitu). Jde o mou první okenní aplikaci.

---

## Funkce aplikace

- Zadání seznamu soutěžících (jméno po jméně)
- Volba počtu výherců, kteří se mají vylosovat
- Náhodné vylosování zadaného počtu jmen ze seznamu
- Smazání soutěžícího ze seznamu
- Automatická oprava zadaného jména na velké počáteční písmeno (i při chybném malém písmeni)

## Průběh losování

Losování má punc dramatičnosti – po dobu dvou sekund běží animace v progress baru, tlačítko **Losovat** je po tuto dobu nefunkční, a po uplynutí této doby se v boxu **Výherci** zobrazí jména vylosovaných.

---

## Struktura projektu

```text
/Losovac
├── Form1.cs
├── Form1.Designer.cs
├── Program.cs
└── README.md
```

---

### Externí knihovny

- **InputHelper** – automatická oprava zadaného jména na formát s velkým počátečním písmenem (`TitleCase.ToTitleCase`). Losovač používá starší, jednodušší verzi knihovny, protože pracuje pouze se jmény, ne s dalšími typy vstupů (města, validace apod.).

---

## Použité techniky

- WinForms (Windows Forms)
- Práce s `ProgressBar` a `Timer` pro animaci losování
- Náhodný výběr prvků ze seznamu
- Validace a úprava textového vstupu přes sdílenou knihovnu

---

## Release

**v1.0.0** – První vydaná verze. Zadání soutěžících, volba počtu výherců, losování s animací v progress baru.  

**v1.1.0** – Opraven název okna aplikace. Přidána možnost smazání soutěžícího ze seznamu.  

**v1.2.0** – Přidána knihovna `InputHelper` – zadané jméno se nyní automaticky opraví na velké počáteční písmeno i v případě chybného zadání s malým písmenem.  

[Aktuální verze ke stažení zde](https://github.com/AdriansRepos/LosovacProJuniorGuru/releases)

</details>

---

<details>
<summary>🇺🇸 <strong>ENGLISH (English Version)</strong></summary>

# Losovač – WinForms C# Application

Losovač is a simple Windows Forms desktop application built for drawing winners from a list of contestants (created for the Junior Guru community). It marks my very first desktop windowed application.

---

## Features

- Enter a list of contestants (name by name).
- Choose the number of winners to draw.
- Randomly draw the specified number of names from the list.
- Delete a contestant from the list.
- Automatic text formatting to ensure names start with a capital letter (even if entered incorrectly in lowercase).

## Drawing Process

The drawing features a touch of suspense—a progress bar animation runs for two seconds, during which the **Draw** button is disabled, followed by displaying the winners in the **Winners** box.

---

## Project Structure

```text
/Losovac
├── Form1.cs
├── Form1.Designer.cs
├── Program.cs
└── README.md
```

---

### External Libraries

- **InputHelper** – Automatic name formatting to TitleCase (`TitleCase.ToTitleCase`). Losovač uses a lightweight, specialized version of this library since it focuses solely on names rather than complex validations or city-name prepositions.

---

## Core Techniques & Patterns

- Windows Forms (WinForms)
- Working with `ProgressBar` and `Timer` for drawing animations
- Random element selection from collections
- Text input validation and sanitization via shared library

---

## Release History

- **v1.0.0** – Initial release. Contestant input, winner count selection, and progress bar animation drawing.  

- **v1.1.0** – Fixed application window title. Added ability to delete contestants from the list.  

- **v1.2.0** – Integrated `InputHelper` library – names are now automatically formatted to start with a capital letter.  

[Downolad latest release here](https://github.com/AdriansRepos/LosovacProJuniorGuru/releases)

</details>