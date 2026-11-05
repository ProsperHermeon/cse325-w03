# CSE 325 – W03: Blazing Pizza (Blazor)

Prosper Opara · United States

The Blazing Pizza app from Microsoft Learn's [Build web apps with Blazor](https://learn.microsoft.com/en-us/training/paths/build-web-apps-with-blazor/) path, finished through the [Use pages, routing, and layouts to improve Blazor navigation](https://learn.microsoft.com/en-us/training/modules/use-pages-routing-layouts-control-blazor-navigation/) module. Built on .NET 10 LTS.

## Module work

- **Pages and `@page` routing:** `Checkout.razor` (`/checkout`), `MyOrders.razor` (`/myorders`)
- **Placing orders:** `OrdersController` API and Entity Framework support for orders and pizzas
- **NavLink navigation** with the active tab highlighted
- **Route parameters:** `OrderDetail.razor` at `/myorders/{orderId:int}`, restricted to integers
- **Shared layout:** `Shared/MainLayout.razor` with the header and footer, set as the default layout in `App.razor`

## My additions

| Requirement | How |
|---|---|
| Prices in my country's currency (US dollars) everywhere | `Model/PriceFormat.cs` formats every price with the `en-US` culture (`$12.75`). The pizza cards, the order dialog, the cart and total, checkout, My Orders, and order tracking all use it. I removed the hard-coded `£` signs from the pages and from `site.css`. |
| Full name and country in the footer | `Shared/MainLayout.razor`: `© Blazing Pizza 2026 · Prosper Opara · United States`, styled in `site.css` so it stays visible at the bottom of every page |

## Run it

```bash
dotnet run
```

Then open http://localhost:5000. The SQLite database (`pizza.db`) is created and seeded on the first run.
