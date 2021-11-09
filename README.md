# Flight Booking System POC

This projects is a little Proof Of Concept aimed to refresh my knowledge on .Net and other technologies before joining my next company.

The idea is to build a complete booking system for flights. So, I will build:

- a mock for NDC
- a backend for maintaining a flights database and some simple business rules
- a booking engine for own product
- an API aggregator
- a B2C website, consuming the public API
- a website to stress the system / showcase it


Here follow some tech decisions which come to my mind at this point:

- I will publish Docker images for all of these services, and I will provide instructions for deploying them using Kubernetes
- I will use Consul as the service mesh
- DDD approach wherever a model makes sense 
- EF for persistence
- need to look for a good L2 cache solution in .Net
- CQRS approach for the booking engine backend -> API
- I will use RabbitMQ for messages
- ELK for distributed log / traffic analysis
- Blazor for building the backend
- SSG (Hugo) for the B2C website
- MVP approach at the B2C dynamic part
  - typescript + Vue | Svelte
  - published at npm 
- the B2C website will be deployed on a CDN like Netlify
- xUnit for c# unit tests
- use ArchUnitNET for arch checking
- surely both Selenium and Cypress for integration tests
- Github Actions for CI
- performance tests at some point

Please note that this is not about building a perfect flight booking system, but about training ;) 


