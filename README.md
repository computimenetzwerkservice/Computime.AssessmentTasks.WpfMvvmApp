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