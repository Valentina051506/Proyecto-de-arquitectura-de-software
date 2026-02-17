# Proyecto-de-arquitectura-de-software
<div align="center">

# RedMotor ERP

### Sistema ERP especializado para concesionarios de vehículos



---

*Universidad Manuela Beltrán — Arquitectura de Software — 2026*

</div>

---

## Tabla de Contenido

- Descripción del Proyecto
- Problemática
- Solución Propuesta
- Módulos del Sistema
- Diagramas
- Requisitos No Funcionales
- Alcance y Limitaciones
- Equipo
- Enlaces

---

## Descripción del Proyecto

**RedMotor ERP** es un sistema de planificación de recursos empresariales (ERP) diseñado específicamente para concesionarios de vehículos. Su objetivo es centralizar e integrar en una sola plataforma todos los procesos operativos del negocio, eliminando la fragmentación de información y mejorando la eficiencia administrativa.

---

## Problemática

Un concesionario gestiona múltiples procesos de forma simultánea: inventario de vehículos, clientes, ventas, facturación, financiamiento, comisiones y garantías. Cuando estas actividades se administran con herramientas distintas, se generan problemas como:

- Información fragmentada entre sistemas
- Inconsistencias de datos
- Errores en cálculos financieros
- Poca trazabilidad en el ciclo de vida del vehículo
- Dificultad al generar reportes consolidados

---

## Solución Propuesta

RedMotor ERP integra en una sola plataforma web todos los procesos del concesionario, permitiendo:

- Automatizar tareas operativas repetitivas
- Reducir errores humanos en procesos críticos
- Centralizar la información en una base de datos única
- Mejorar el control financiero y la toma de decisiones
- Optimizar la experiencia del cliente

---

## Módulos del Sistema

| Módulo | Descripción |
|--------|-------------|
| **Seguridad** | Autenticación JWT, control de acceso por roles |
| **Inventario** | Ciclo de vida del vehículo: disponible → reservado → vendido → garantía |
| **Clientes (CRM)** | Registro, seguimiento e historial de clientes |
| **Ventas y Facturación** | Registro de ventas, emisión automática de facturas |
| **Financiamiento** | Simulación de créditos y gestión de cuotas |
| **Comisiones** | Cálculo automático de comisiones por vendedor |
| **Garantías** | Seguimiento posventa y gestión de garantías activas |
| **Reportes** | Reportes en tiempo real: ventas, inventario, rentabilidad |

---

## Diagramas

| Diagrama | Descripción |
|----------|-------------|
| **Contexto (C4 - L1)** | Actores externos e internos del sistema |
| **Contenedores (C4 - L2)** | Frontend, Backend, Seguridad y Base de Datos |
| **Componentes (C4 - L3)** | Módulos internos del Backend API REST |
| **Casos de Uso** | Funcionalidades por actor del sistema |
| **Secuencia** | Flujos principales: login, venta, financiamiento, garantías |
| **Entidad - Relación** | Modelo de datos completo del sistema |

> Los diagramas en PlantUML están disponibles en la carpeta [`/diagrams`](./diagrams)

---

## Requisitos No Funcionales

| Requisito | Detalle |
|-----------|---------|
| **Usabilidad** | Interfaz intuitiva y responsiva para todos los roles |
| **Rendimiento** | Respuesta en menos de 3 segundos en consultas comunes |
| **Seguridad** | JWT + BCrypt + control de acceso por roles |
| **Escalabilidad** | Arquitectura modular para agregar nuevos módulos |
| **Disponibilidad** | Operativo durante horario laboral sin interrupciones críticas |
| **Mantenibilidad** | Código modular bajo principios SOLID |

---

## Alcance y Limitaciones

### Incluye (v1.0)
- Gestión completa de inventario de vehículos
- CRM básico para clientes
- Ventas y facturación automática
- Simulación de financiamiento
- Cálculo automático de comisiones
- Reportes administrativos y financieros en tiempo real
- Control de estados del vehículo
- Acceso por roles (administrador, vendedor, contador, servicio)

### No incluye (v1.0)
- Integración directa con bancos reales (solo simulación)
- Comercio electrónico para venta en línea
- Aplicación móvil nativa (solo versión web responsiva)
- Integración con sistemas gubernamentales externos
- Soporte multiempresa (diseñado para un solo concesionario)

---

## Equipo

| Nombre | Rol |
|--------|-----|
| **Natalia Valentina Omaña Pérez** | Desarrolladora |
| **Juan Gabriel Gutiérrez Trujillo** | Desarrollador |
| **Samuel Ossa Escobar** | Desarrollador |

---

## Enlaces

- 🎨 [Prototipo Figma](https://www.figma.com/make/PieMlqJSy6aayMBCZiiLbm/Automotive-ERP-UI-Design-System?p=f&fullscreen=1)

---

<div align="center">

**Universidad Manuela Beltrán · Bogotá D.C. · 2026**

*Arquitectura de Software*

</div>
