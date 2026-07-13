# SystemDelivery

🚚 Aplicación de escritorio desarrollada en C# (.NET 8) con Windows Forms que gestiona clientes, productos, pedidos, repartidores y rutas para un sistema de delivery. 🛵

![Vista previa de SystemDelivery](readme.webp)

## Estructura del Proyecto

El proyecto está organizado de la siguiente manera:

- SystemDelivery.sln
- SystemDelivery.csproj
- Program.cs
- Properties/ (recursos)
- Entidades/ (modelos: Cliente, Pedido, Producto, Repartidor, Zona)
- Datos/ (acceso a datos: ProductoDatos)
- Estructuras/ (implementaciones de listas, pilas, colas, grafos, ABB, etc.)
  - ListaSimple/
  - ListaCircular/
  - ListaDoble/
  - ListaProductos/
  - Pila/
  - Cola/
  - ColaPrioridad/
  - Grafos/
  - ABB/
- Formularios/ (UI: formularios y sus diseñadores)
- Sistema/ (lógica central: SistemaDelivery)

## Instalación

Requisitos previos:
- .NET 8 SDK
- Visual Studio 2026 o superior (recomendado) o CLI de .NET

Pasos:
1. Clona el repositorio: git clone <url-del-repositorio>
2. Abre la solución en Visual Studio (SystemDelivery.sln) y compila (Build > Rebuild Solution), o desde la CLI en la carpeta del proyecto:
   - dotnet restore
   - dotnet build
   - dotnet run --project SystemDelivery.csproj

## Contribución

Si deseas contribuir a este proyecto, por favor lee nuestras [Guías de Contribución](./CONTRIBUTING.md) para obtener información detallada sobre el proceso de envío de cambios.

## Licencia

Este proyecto está licenciado bajo la Licencia MIT. Esto significa que puedes usar, modificar y distribuir el código bajo los términos de esta licencia.
Para más detalles, consulta el archivo [LICENSE](./LICENSE)

## Contacto

Para cualquier consulta o sugerencia, por favor contacta a través de [steffanod948@gmail.com](mailto:steffanod948@gmail.com).
