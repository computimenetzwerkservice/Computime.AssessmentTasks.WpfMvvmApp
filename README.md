# Computime.AssessmentTasks.WpfMvvmApp

## Bewerberaufgabe Teil 1

### Ziel
Erstellen Sie eine WPF-Anwendung, die es ermöglicht, Personen zu einer Liste hinzuzufügen und diese Liste in einem DataGrid anzuzeigen.

### Anforderungen

1. **Personenklasse**:
   - Verwenden Sie die vorhandene `Person`-Klasse aus dem Namespace `Computime.AssessmentTasks.WpfMvvmApp.Models`.
   - Die Klasse `Person` hat die folgenden Eigenschaften:
     - `int Age`
     - `string FirstName`
     - `string LastName`
     - `DateTime? LastUpdated`

2. **Benutzeroberfläche**:
   - Erstellen Sie Textboxen für die Eingabe der Eigenschaften `Age`, `FirstName` und `LastName`.
   - Fügen Sie einen Button hinzu, der eine neue Person zur Liste hinzufügt.
   - Zeigen Sie die Liste der Personen in einem DataGrid an.

### Schritte

1. **Erstellen der Benutzeroberfläche**:
   - Fügen Sie Textboxen für die Eingabe von `Age`, `FirstName` und `LastName` hinzu.
   - Fügen Sie einen Button mit der Beschriftung "Hinzufügen" hinzu.
   - Fügen Sie ein DataGrid hinzu, um die Liste der Personen anzuzeigen.

2. **Logik zum Hinzufügen von Personen**:
   - Implementieren Sie die Logik, um eine neue Person zu erstellen und zur Liste hinzuzufügen, wenn der "Hinzufügen"-Button geklickt wird.
   - Aktualisieren Sie das DataGrid, um die neue Person anzuzeigen.

3. **Datenbindung**:
   - Verwenden Sie Datenbindung, um die Textboxen und das DataGrid mit den Eigenschaften der `Person`-Klasse zu verknüpfen.

## Bewerberaufgabe Teil 2

### Ziel
Erweitern Sie die WPF-Anwendung, um die erfassten Personen in einer EF Core In-Memory Database zu speichern. Implementieren Sie die Standard-CRUD-Methoden (Create, Read, Update, Delete) und stellen Sie deren korrekte Funktion sicher.

### Anforderungen

1. **Einrichten der EF Core In-Memory Database**:
   - Installieren Sie die erforderlichen NuGet-Pakete für EF Core und die In-Memory Database.
   - Konfigurieren Sie den DbContext für die In-Memory Database.

2. **CRUD-Methoden**:
   - Implementieren Sie die folgenden Methoden:
     - `CreatePerson(Person person)`: Fügt eine neue Person zur Datenbank hinzu.
     - `ReadPersons()`: Liest alle Personen aus der Datenbank.
     - `UpdatePerson(Person person)`: Aktualisiert eine bestehende Person in der Datenbank.
     - `DeletePerson(int personId)`: Löscht eine Person aus der Datenbank.

3. **Integration in das ViewModel**:
   - Passen Sie das ViewModel an, um die Create-Methode zu nutzen.
   - Stellen Sie sicher, dass die Daten im DataGrid korrekt angelegt werden.
   - Hinweis: Die Lesen, Aktualisieren und Löschen-Methoden sind optional.

### Schritte

1. **Einrichten der EF Core In-Memory Database**:
   - Fügen Sie die folgenden NuGet-Pakete zu Ihrem Projekt hinzu:
     - `Microsoft.EntityFrameworkCore`
     - `Microsoft.EntityFrameworkCore.InMemory`
   - Erstellen Sie eine neue Klasse `AppDbContext`, die von `DbContext` erbt und eine `DbSet<Person>`-Eigenschaft enthält.

2. **Implementieren der CRUD-Methoden**:
   - Erstellen Sie eine neue Klasse `PersonRepository`, die die CRUD-Methoden implementiert.
   - Verwenden Sie den `AppDbContext` in den Methoden, um die Datenbankoperationen durchzuführen.

3. **Anpassen der Benutzeroberfläche**:
   - Passen Sie die Logik in der `MainWindow`-Klasse an, um die Methoden des `PersonRepository` zu nutzen.
   - Stellen Sie sicher, dass die Benutzeroberfläche die Daten korrekt anzeigt und aktualisiert.

### Hinweise
- Achten Sie darauf, dass die Eingaben validiert werden (z.B. Alter muss eine Zahl sein).
- Stellen Sie sicher, dass die Anwendung MVVM-Prinzipien befolgt.

Viel Erfolg bei der Umsetzung!