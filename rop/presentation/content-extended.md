
<<= x =>>
Wenn ein neuer Benutzer sich anmeldet und ***Premiummitglied*** werden m&ouml;chte,
- ...
- wird seine Kreditkarte mit einer Geb&uuml;hr belastet
- wird er im System als Premiummitglied gespeichert

<<= x =>>

```csharp
var customer = MapVmToDm(viewModel);
customer = _customerRepository.Create(customer);

if (viewModel.WantsPremiumSupport)
{
    _creditCardGateway.Charge(customer.CreditCardNumber);
    _customerRepository.Upgrade(customer);
}

_mailConfirmer.SendWelcome(customer);
```

<<= x =>>
...in eine Methode eingebettet...
```csharp
public CustomerCreatedViewModel RegisterCustomer(
            CreateCustomerViewModel createCustomerViewModel)
{            
    var customer = MapVmToDm(createCustomerViewModel);
    customer = _customerRepository.Create(customer);

    if (createCustomerViewModel.WantsPremiumSupport)
    {
        _creditCardGateway.Charge(customer.CreditCardNumber);
        _customerRepository.Upgrade(customer);
    }

    _mailConfirmer.SendWelcome(customer);

    return new CustomerCreatedViewModel(customer.Id) {Success = true};
}
```
Na, dann sind wir ja fertig, oder?


<<= x =>>

*...potentielle Fallstricke...*
<pre>
<code data-noescape data-trim class="lang-csharp hljs">
<span class="mycodemark-highlight">// can fail</span>
var customer = MapVmToDm(createCustomerViewModel);

<span class="mycodemark-highlight">// can fail</span>
customer = _customerRepository.Create(customer);

if (createCustomerViewModel.WantsPremiumSupport)
{
    <span class="mycodemark-highlight">// can fail</span>
    _creditCardGateway.Charge(customer.CreditCardNumber);
    <span class="mycodemark-highlight">// can fail</span>
    _customerRepository.Upgrade(customer);
}

<span class="mycodemark-highlight">// can fail</span>
_mailConfirmer.SendWelcome(customer);

return new CustomerCreatedViewModel(customer.Id) {Success = <span style="color:black;font-weight:bold">??</span>};
</code>
</pre>

