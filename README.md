# Apartment brokerage 
### Entities:
- An apartment.
- An apartment owner.
- A client.

### An apartment routes mapping
Retrieving the list of apartments - https://localhost:7286/api/Apartment<br>
Retrieving an apartment by ID - https://localhost:7286/api/Apartment/1<br>
Adding an apartment - https://localhost:7286/api/Apartment<br>
Apartment update - https://localhost:7286/api/Apartment/1<br>
Status update - https://localhost:7286/api/Apartment/status/1
>I chose not to map Route to delete an apartment. Instead I added Route to update status.

### An apartment owner routes mapping
Retrieving the list of owner  apartments - https://localhost:7286/api/ApartmentOwner<br>
Retrieving an owner apartment by ID - https://localhost:7286/api/ApartmentOwner/1<br>
Adding an owner apartment - https://localhost:7286/api/ApartmentOwner<br>
Owner apartment update - https://localhost:7286/api/ApartmentOwner/1<br>
Owner apartment deletion - https://localhost:7286/api/ApartmentOwner/

### A client routes mapping
Retrieving the list of clients - https://localhost:7286/api/Client<br>
Retrieving a client by ID - https://localhost:7286/api/Client/1<br>
Adding a client - https://localhost:7286/api/Client<br>
Client update - https://localhost:7286/api/Client/1<br>
Client deletion - https://localhost:7286/api/Client/1
