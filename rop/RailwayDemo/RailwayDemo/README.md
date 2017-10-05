Ein Kunde meldet sich am System an...

bedeutet fuer `CustomerRegistrationService.RegisterCustomer`:

Es kommt ein `CreateCustomerRegistrationRequest` als Eingabe an.

Erwartet wird ein `CustomerCreatedResponse` als Rueckgabewert.

Die Antwort (`Response`) beinhaltet das Ergebnis von 

- Validierung des Requests
- Speichern des neuen Kunden
- Senden einer Bestaetigungsmail, wenn die Registrierung erfolgreich war

Es gibt ein Interface fuer
- Speichern ("Repository")
- Mailversand ("Gateway")


### Aufgabe 1

Herk&ouml;mmliche Loesung implementieren (inkl. Tests)

### Aufgabe 2

Loesung mittels Result-Klasse ersetzen

### Hinweis:

- Erstellen eines Results mittels `Result.Ok(...)` / `Result.Fail<T>("error")`
- Verkettung mit `OnSuccess(x => ...)` / `OnFailure(x => ...)`
- Ergebnis auspacken mit `OnBoth(x => ...)`

### Vim plugin

Damit man seine urspruenglichen Einstellungen wieder herstellen kann:

Tools --> Import and Export Settings from Visual Studio. You can deselect all the options except "All Settings --> Options --> Environment --> Keyboard".

This procedure creates a file .vssettings