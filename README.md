# Computime.AssessmentTasks.WpfMvvmApp

## Bewerberaufgabe Teil 1

### Ziel
Erstellen Sie eine WPF-Anwendung, die es erm�glicht, Personen zu einer Liste hinzuzuf�gen und diese Liste in einem DataGrid anzuzeigen.

### Anforderungen

1. **Personenklasse**:
   - Verwenden Sie die vorhandene `Person`-Klasse aus dem Namespace `Computime.AssessmentTasks.WpfMvvmApp.Models`.
   - Die Klasse `Person` hat die folgenden Eigenschaften:
     - `int Age`
     - `string FirstName`
     - `string LastName`
     - `DateTime? LastUpdated`

2. **Benutzeroberfl�che**:
   - Erstellen Sie Textboxen f�r die Eingabe der Eigenschaften `Age`, `FirstName` und `LastName`.
   - F�gen Sie einen Button hinzu, der eine neue Person zur Liste hinzuf�gt.
   - Zeigen Sie die Liste der Personen in einem DataGrid an.

### Schritte

1. **Erstellen der Benutzeroberfl�che**:
   - F�gen Sie Textboxen f�r die Eingabe von `Age`, `FirstName` und `LastName` hinzu.
   - F�gen Sie einen Button mit der Beschriftung "Hinzuf�gen" hinzu.
   - F�gen Sie ein DataGrid hinzu, um die Liste der Personen anzuzeigen.

2. **Logik zum Hinzuf�gen von Personen**:
   - Implementieren Sie die Logik, um eine neue Person zu erstellen und zur Liste hinzuzuf�gen, wenn der "Hinzuf�gen"-Button geklickt wird.
   - Aktualisieren Sie das DataGrid, um die neue Person anzuzeigen.

3. **Datenbindung**:
   - Verwenden Sie Datenbindung, um die Textboxen und das DataGrid mit den Eigenschaften der `Person`-Klasse zu verkn�pfen.

## Bewerberaufgabe Teil 2

### Ziel
Erweitern Sie die WPF-Anwendung, um die erfassten Personen in einer EF Core In-Memory Database zu speichern. Implementieren Sie die Standard-CRUD-Methoden (Create, Read, Update, Delete) und stellen Sie deren korrekte Funktion sicher.

### Anforderungen

1. **Einrichten der EF Core In-Memory Database**:
   - Installieren Sie die erforderlichen NuGet-Pakete f�r EF Core und die In-Memory Database.
   - Konfigurieren Sie den DbContext f�r die In-Memory Database.

2. **CRUD-Methoden**:
   - Implementieren Sie die folgenden Methoden:
     - `CreatePerson(Person person)`: F�gt eine neue Person zur Datenbank hinzu.
     - `ReadPersons()`: Liest alle Personen aus der Datenbank.
     - `UpdatePerson(Person person)`: Aktualisiert eine bestehende Person in der Datenbank.
     - `DeletePerson(int personId)`: L�scht eine Person aus der Datenbank.

3. **Integration in das ViewModel**:
   - Passen Sie das ViewModel an, um die Create-Methode zu nutzen.
   - Stellen Sie sicher, dass die Daten im DataGrid korrekt angelegt werden.
   - Hinweis: Die Lesen, Aktualisieren und L�schen-Methoden sind optional.

### Schritte

1. **Einrichten der EF Core In-Memory Database**:
   - F�gen Sie die folgenden NuGet-Pakete zu Ihrem Projekt hinzu:
     - `Microsoft.EntityFrameworkCore`
     - `Microsoft.EntityFrameworkCore.InMemory`
   - Erstellen Sie eine neue Klasse `AppDbContext`, die von `DbContext` erbt und eine `DbSet<Person>`-Eigenschaft enth�lt.

2. **Implementieren der CRUD-Methoden**:
   - Erstellen Sie eine neue Klasse `PersonRepository`, die die CRUD-Methoden implementiert.
   - Verwenden Sie den `AppDbContext` in den Methoden, um die Datenbankoperationen durchzuf�hren.

3. **Anpassen der Benutzeroberfl�che**:
   - Passen Sie die Logik in der `MainWindow`-Klasse an, um die Methoden des `PersonRepository` zu nutzen.
   - Stellen Sie sicher, dass die Benutzeroberfl�che die Daten korrekt anzeigt und aktualisiert.

### Hinweise
- Achten Sie darauf, dass die Eingaben validiert werden (z.B. Alter muss eine Zahl sein).
- Stellen Sie sicher, dass die Anwendung MVVM-Prinzipien befolgt.

Viel Erfolg bei der Umsetzung!