# Blazor 

## Introduction

Welcome! This is the portfolio repository created in Blazor Web Assembly.

To take this website you'll need the following.

1. The [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0).
2. Clone this git repository from GitHub.

## Get started

Clone the Git Repository
``` bash
git clone https://github.com/sages-blazor-portfolio
```

## Setup
``` bash
cd src
dotnet run
```

## Mockup

![Mockup](/ui-mockup.png)


## Tutorial

1. Utwórz projekt **MyPortfolio** na podstawie szablonu **Blazor Web Assembly App Empty**
2. Skopiuj pliki z folderu _Assets_ do folderu _wwwroot_

3. Dodaj folder _Models_ i dodaj klasy modelu:
- AboutMe.cs
- Project.cs
- SiteProperties.cs
- SocialIcons.cs

4. Utwórz folder **Shared** i dodaj w nim komponenty **Razor Component**:
- Header.razor
- Footer.razor

6. Umieść komponenty w MainLayout.razor

```html
<Header />
  <main id="main">@Body</main>
<Footer />
```
7. Dodaj do pliku _Imports.razor globalne przestrzenie
```html
@using MyPortfolio.Shared
@using MyPortfolio.Models
@using MyPortfolio.Components
```

8. Dodaj do Header

```html
<nav class="navbar top-row">
  <a href="#home" target="_top">Home</a>
  <a href="#about" target="_top">About</a>
  <a href="#portfolio" target="_top">Portfolio</a>
  <a href="#contact" target="_top">Contact</a>
</nav>
```

9. Utwórz folder Components w a nim:

- Home.razor
- About.razor
- Portfolio.razor
- Contact.razor

10. Umieść na stronie **Pages/Index.razor**

```html
<PageTitle>Portfolio</PageTitle>
<Home />
<About />
<Portfolio />
<Contact />
```

10. W wwwroot/index.html odkomentuj linię aby włączyć mechanizm **CSS isolation**

11. Dodaj style
- Home.razor.css
- About.razor.css
- Contact.razor.css
- Portfolio.razor.css

