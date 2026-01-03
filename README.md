# Eps.Booking

## Descripción del Proyecto
Eps.Booking es una solución diseñada para gestionar citas médicas, disponibilidad de doctores, clínicas y pacientes. Este proyecto sigue los principios de la **Clean Architecture**, asegurando un diseño modular, escalable y fácil de mantener.

## Estructura del Proyecto
El proyecto está organizado en los siguientes módulos principales:

- **Eps.Booking.Api**: Contiene la API principal para interactuar con el sistema.
- **Eps.Booking.Application**: Contiene la lógica de negocio y los casos de uso.
- **Eps.Booking.Common**: Contiene utilidades y componentes compartidos.
- **Eps.Booking.Domain**: Define las entidades principales y las enumeraciones del dominio.
- **Eps.Booking.External**: Maneja integraciones externas.
- **Eps.Booking.Persistence**: Gestiona la persistencia de datos y configuraciones de base de datos.

## Arquitectura
El proyecto sigue los principios de **Clean Architecture**, que promueve la separación de responsabilidades y la independencia de los módulos. A continuación, se muestra un diagrama representativo:

![Clean Architecture](https://miro.medium.com/v2/resize:fit:1400/format:webp/1*ZdlHz8B0_5zD1pNe1ZAc_w.png)

### Principios Clave de Clean Architecture:
- **Independencia de Frameworks**: El sistema no depende de frameworks externos.
- **Testabilidad**: Los casos de uso pueden ser probados de manera aislada.
- **Independencia de la UI**: La interfaz de usuario puede cambiar sin afectar la lógica de negocio.
- **Independencia de la Base de Datos**: La lógica de negocio no depende de detalles de la base de datos.

## Requisitos Previos
- **.NET SDK**: Asegúrate de tener instalado el SDK de .NET.
- **Terraform**: Para gestionar la infraestructura como código.

## Configuración del Proyecto
1. Clona el repositorio:
   ```bash
   git clone <URL_DEL_REPOSITORIO>
   ```
2. Navega al directorio del proyecto:
   ```bash
   cd api_booking
   ```
3. Restaura las dependencias:
   ```bash
   dotnet restore
   ```
4. Configura la infraestructura con Terraform:
   ```bash
   cd IaC
   terraform init
   terraform apply
   ```

## Ejecución del Proyecto
1. Navega al directorio de la API:
   ```bash
   cd src/Eps.Booking.Api
   ```
2. Ejecuta la aplicación:
   ```bash
   dotnet run
   ```
3. Accede a la API en tu navegador o herramienta de pruebas en:
   ```
   http://localhost:5000
   ```

## Contribuciones
¡Las contribuciones son bienvenidas! Por favor, sigue los pasos a continuación:
1. Crea un fork del repositorio.
2. Crea una nueva rama para tu funcionalidad o corrección de errores.
3. Envía un pull request describiendo tus cambios.

## Licencia
Este proyecto está bajo la licencia [MIT](LICENSE).

---

¡Gracias por usar Eps.Booking! Si tienes alguna pregunta o sugerencia, no dudes en abrir un issue en el repositorio.