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