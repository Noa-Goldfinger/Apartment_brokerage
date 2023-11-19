# Apartment brokerage 
### Entities:
- An apartment.
- An apartment owner.
- A client.

### An apartment routes mapping
Retrieving the list of apartments-https://localhost:7286/api/Apartment
Retrieving an apartment by ID-https://localhost:7286/api/Apartment/1
Adding an apartment-https://localhost:7286/api/Apartment
Apartment update-https://localhost:7286/api/Apartment/1
Status update-https://localhost:7286/api/Apartment/status/1
>I chose not to map Route to delete an apartment. Instead I added Route to update status.

### An apartment owner routes mapping
Retrieving the list of owner  apartments.-https://localhost:7286/api/ApartmentOwner
Retrieving an owner apartment by ID.-https://localhost:7286/api/ApartmentOwner/1
Adding an owner apartment.-https://localhost:7286/api/ApartmentOwner
Owner apartment update.-https://localhost:7286/api/ApartmentOwner/1
Owner apartment deletion.-https://localhost:7286/api/ApartmentOwner/1

### A client routes mapping
Retrieving the list of clients.- https://localhost:7286/api/Client
Retrieving a client by ID.-https://localhost:7286/api/Client/1
Adding a client. -https://localhost:7286/api/Client
Client update.  -https://localhost:7286/api/Client/1
Client deletion.  -https://localhost:7286/api/Client/1
