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


