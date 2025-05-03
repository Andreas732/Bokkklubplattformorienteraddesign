# Bokkklubplattformorienteraddesign
Bokklubbplattform
Designmönster: Factory Pattern

Jag använder Factory Pattern för att hantera olika typer av bokklubbar i mitt system. Genom en fabriksklass kan vi skapa bokklubbar dynamiskt utan att behöva instansiera specifika klasser i huvudkoden. Detta gör koden mer flexibel, underhållbar och följer Open-Closed Principle, vilket innebär att vi kan lägga till nya bokklubbar utan att ändra den befintliga koden.

Exempel på bokklubbar i systemet: Skönlitteraturklubb, Facklitteraturklubb och Barnbokklubb. Fabriksklassen BokklubbFabrik skapar rätt bokklubb baserat på användarens val, och om nya klubbar läggs till, behövs bara en ny klass och en uppdatering i fabriken.

Use Case: Välj bokklubb
Aktör: Användare som vill gå med i en bokklubb.

Scenario:

Användaren loggar in och väljer att gå med i en bokklubb.

Plattformen visar tillgängliga bokklubbar (t.ex. Skönlitteraturklubb, Facklitteraturklubb).

Användaren väljer en klubb och systemet skapar den valda bokklubben.

Användning av Factory Pattern: Fabriken skapar rätt bokklubb baserat på användarens val utan att behöva specificera detaljer i huvudkoden.

User Story: Gå med i en bokklubb
Titel: Välj och gå med i en bokklubb

Som användare,
vill jag kunna välja en bokklubb,
så att jag kan gå med i en klubb som passar mina intressen.

AC1: Jag ska kunna se alla bokklubbar.
AC2: När jag väljer en bokklubb skapas den rätta klubben automatiskt.
AC3: Jag behöver inte veta detaljerna om varje bokklubb, fabriken sköter det åt mig.

💡 Varför jag valt Factory Pattern
Jag har valt Factory Pattern eftersom det ger mig en flexibel och skalbar lösning för att hantera olika typer av innehåll på bokklubbplattformen – såsom Recensioner, Diskussioner och Event. Plattformen kommer potentiellt att växa, vilket innebär att fler innehållstyper kan behöva läggas till i framtiden. Genom att använda en fabrik för att skapa innehållsobjekt isolerar jag objektinstansieringen och minskar beroenden i vår huvudlogik.
