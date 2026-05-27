# MarketSoft

MarketSoft es un sistema de punto de venta desarrollado en C# con Windows Forms.  
La aplicación permite gestionar clientes, productos y ventas de manera organizada mediante una interfaz gráfica sencilla y aplicando Programación Orientada a Objetos.

El sistema está orientado a pequeños negocios que necesitan controlar inventario y ventas de forma eficiente.

---

# Integrantes

| Nombre | Rol | Responsabilidades principales |
|---|---|---|
| Mariana López | Desarrollo GUI | Formularios, eventos y validaciones |
| Anderson León | Líder técnico | Modelo, arquitectura y lógica de negocio |
| Sara Machado | Documentación y pruebas | README, UML, pruebas y presentación |

---

# Descripción del problema

Muchos pequeños negocios realizan el control de productos y ventas de manera manual, lo que puede generar errores, pérdida de información y dificultades para administrar inventario y clientes.

MarketSoft busca solucionar este problema mediante una aplicación de escritorio que permita registrar productos, clientes y ventas de manera organizada.

---

# Objetivo del sistema

El sistema busca:

- Registrar productos.
- Registrar clientes.
- Registrar ventas.
- Listar información almacenada.
- Buscar registros.
- Eliminar registros.
- Calcular totales e IVA.
- Validar entradas del usuario.

---

# Tecnologías utilizadas

- C#
- .NET 8
- Windows Forms
- Visual Studio Code
- Git y GitHub

---

# Requisitos previos

Antes de ejecutar el proyecto se necesita:

- Tener instalado .NET SDK.
- Tener instalado Visual Studio Code.
- Tener instalada la extensión de C# para VS Code.
- Clonar el repositorio.

---

#  Instalación

```bash
git clone https://github.com/andersonleon066-ai/MarketSoft.git
cd MarketSoft
```
---

#  Ejecución

Desde la terminal:

```bash
dotnet run
```

---

# Funcionalidades principales

- Crear registros.
- Listar registros.
- Buscar registros.
- Eliminar registros.
- Validar entradas del usuario.
- Mostrar mensajes de error o confirmación.
- Calcular IVA y totales de ventas.
- Controlar stock de productos.

---

#  Estructura del proyecto

```text
MarketSoft/
│
├── Modelo/
│   ├── Persona.cs
│   ├── Cliente.cs
│   ├── Empleado.cs
│   ├── Cajero.cs
│   ├── Producto.cs
│   └── Venta.cs
│
├── Vista/
│   ├── FormMenu.cs
│   ├── FormProductos.cs
│   ├── FormClientes.cs
│   └── FormVentas.cs
│
├── Servicios/
│   ├── ServicioCliente.cs
│   ├── ServicioProducto.cs
│   ├── ServicioVenta.cs
│   ├── ServicioEmpleado.cs
│   └── ServicioCajero.cs
│
├── Utilidades/
│   └── Validador.cs
│
├── Diagramas/
│
├── Program.cs
└── README.md
```

---

# Arquitectura

La arquitectura del proyecto está organizada por capas:

- La vista recibe datos y acciones del usuario mediante formularios.
- Los servicios validan y procesan la lógica del negocio.
- El modelo representa las entidades principales del sistema.
- La capa de utilidades contiene validaciones y funciones auxiliares.

---

# Diagrama UML

![Diagrama de clases](Diagramas/clases.png)
![Diagrama de servicios](Diagramas/servicios.png)

---

# Capturas de pantalla


![Menú principal](Diagramas/menu.png)
![Formulario productos](Diagramas/productos.png)
![Formulario clientes](Diagramas/clientes.png)
![Formulario ventas](Diagramas/ventas.png)
![Formulario salir](Diagramas/salir.png)


---

#  Ejemplo de uso

1. Abrir la aplicación.
2. Registrar un producto.
3. Registrar un cliente.
4. Consultar registros almacenados.
5. Registrar una venta.
6. Calcular total de la compra.

---

#  Validaciones implementadas

- Campos obligatorios.
- Validación de números positivos.
- Validación de rangos de edad.
- Validación de stock.
- Confirmación antes de eliminar.
- Mensajes de error comprensibles.

---

#  Conceptos de POO aplicados

## Clases y objetos

Se modelaron entidades como:

- Producto
- Cliente
- Venta
- Empleado
- Cajero

## Encapsulamiento

Uso de:
- atributos privados y protegidos,
- propiedades,
- validaciones internas.

## Herencia

- Cliente hereda de Persona.
- Empleado hereda de Persona.
- Cajero hereda de Empleado.

## Polimorfismo

Uso de sobrescritura de métodos:

- MostrarRol()
- MostrarInfo()

## Uso de colecciones genéricas

```csharp
List<Producto>
List<Cliente>
List<Venta>
```

---

#  Limitaciones conocidas

- Los datos no se guardan en base de datos.
- No existe autenticación de usuarios.
- No existe persistencia en archivos.
- La interfaz gráfica puede mejorarse visualmente.

---

#  Mejoras futuras

- Persistencia en base de datos.
- Autenticación de usuarios.
- Generación de reportes.
- Exportación a PDF o Excel.
- Interfaz más completa.

---

#  Declaración de uso de IA

Herramienta utilizada: ChatGPT, Claude y Gemini

Propósito: apoyo en organización de arquitectura, validaciones, solución de errores y estructura del README.

Solicitudes principales:
- Explicación de herencia y polimorfismo.
- Organización de carpetas.
- Validaciones para formularios.
- Estructura del README.
- Solución de errores de compilación.

Partes impactadas:
- README.md
- Servicios
- Formularios
- Clase Validador.cs

Adaptaciones realizadas:
El equipo ajustó nombres, validaciones, mensajes y lógica según las necesidades del proyecto.

Validación realizada:
Pruebas manuales del funcionamiento de formularios, validaciones y operaciones CRUD.

Responsables:
- Mariana López: interfaz gráfica y validaciones.
- Anderson León: arquitectura y lógica del sistema.
- Sara Machado: documentación, pruebas y revisión.

Declaración:
El equipo comprende el código implementado y puede explicarlo durante la sustentación.

---

# Licencia y créditos

Proyecto desarrollado con fines académicos para la asignatura Herramientas de Programación.

Referencias:
- Documentación oficial de Microsoft .NET
- Microsoft Learn
- Documentación de Windows Forms
