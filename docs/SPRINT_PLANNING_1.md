# Sprint Planning 1 — RedMotor ERP

**Fecha:** Febrero 2026
**Duración:** 2 semanas
**Equipo:** Natalia Valentina Omaña · Juan Gabriel Gutiérrez · Samuel Ossa
**Herramienta:** GitHub Projects

---

## 1. Objetivo del Sprint

> **"Implementar el módulo de Inventario de Vehículos con registro, consulta y actualización de estado, validado con pruebas y desplegado en entorno local."**

Este objetivo es medible porque al finalizar el Sprint se podrá:
- Registrar un vehículo nuevo con todos sus atributos
- Consultar el inventario completo y filtrar por estado
- Cambiar el estado de un vehículo (disponible → reservado → vendido)
- Ver los cambios reflejados en la base de datos en tiempo real

---

## 2. Historias de Usuario

### HU-01 — Registrar vehículo
> **Como** administrador,
> **quiero** registrar un nuevo vehículo con sus datos completos,
> **para** que quede disponible en el inventario del concesionario.

**Criterios de aceptación:**
- El formulario debe pedir: VIN, marca, modelo, año, color, precio, kilometraje, tipo
- El estado inicial siempre es "disponible"
- Si el VIN ya existe, el sistema muestra un error
- Al guardar, el vehículo aparece en el listado de inventario

---

### HU-02 — Consultar inventario
> **Como** vendedor o administrador,
> **quiero** ver el listado completo de vehículos con sus estados,
> **para** saber qué vehículos están disponibles para la venta.

**Criterios de aceptación:**
- Se muestra una tabla con todos los vehículos
- Se puede filtrar por estado: disponible, reservado, vendido, entregado, en garantía
- Se puede buscar por marca, modelo o VIN
- La información se actualiza en tiempo real

---

### HU-03 — Actualizar estado del vehículo
> **Como** vendedor,
> **quiero** cambiar el estado de un vehículo,
> **para** reflejar su situación actual dentro del concesionario.

**Criterios de aceptación:**
- Solo se puede avanzar en el flujo: disponible → reservado → vendido → entregado
- El cambio queda registrado con fecha y usuario que lo realizó
- No se puede retroceder el estado sin permisos de administrador
- Se muestra confirmación antes de cambiar el estado

---

### HU-04 — Eliminar vehículo del inventario
> **Como** administrador,
> **quiero** eliminar un vehículo del inventario,
> **para** mantener el sistema limpio de registros erróneos.

**Criterios de aceptación:**
- Solo el administrador puede eliminar vehículos
- Solo se puede eliminar si el estado es "disponible"
- El sistema pide confirmación antes de eliminar
- El vehículo desaparece del listado tras la eliminación

---

## 3. Planning Poker — Estimación

| ID | Historia | Complejidad | Story Points |
|----|----------|-------------|--------------|
| HU-01 | Registrar vehículo | Media-Alta (formulario + validaciones + API) | **8 SP** |
| HU-02 | Consultar inventario | Media (listado + filtros + búsqueda) | **5 SP** |
| HU-03 | Actualizar estado | Media (lógica de flujo de estados) | **5 SP** |
| HU-04 | Eliminar vehículo | Baja (CRUD básico con validación de rol) | **3 SP** |
| | | **TOTAL** | **21 SP** |

**Escala Fibonacci usada:** 1 · 2 · 3 · 5 · 8 · 13 · 21

---

## 4. Desglose Técnico por Historia

### HU-01 — Registrar vehículo (8 SP)

| Tarea | Tipo | Responsable | Tiempo est. |
|-------|------|-------------|-------------|
| Crear entidad `Vehiculo` y repositorio JPA | Backend | Samuel | 2h |
| Crear endpoint `POST /inventario/vehiculos` | Backend | Samuel | 2h |
| Validaciones de datos y manejo de errores | Backend | Samuel | 1h |
| Crear formulario de registro en React | Frontend | Natalia | 3h |
| Conectar formulario con API REST | Frontend | Natalia | 1h |
| Pruebas unitarias del endpoint | Pruebas | Juan Gabriel | 2h |
| Documentar endpoint en README/docs | Docs | Juan Gabriel | 1h |

---

### HU-02 — Consultar inventario (5 SP)

| Tarea | Tipo | Responsable | Tiempo est. |
|-------|------|-------------|-------------|
| Crear endpoint `GET /inventario/vehiculos` con filtros | Backend | Samuel | 2h |
| Implementar filtro por estado y búsqueda | Backend | Samuel | 1h |
| Crear tabla de inventario en React | Frontend | Natalia | 3h |
| Implementar filtros y buscador en UI | Frontend | Natalia | 2h |
| Pruebas de integración del listado | Pruebas | Juan Gabriel | 1h |

---

### HU-03 — Actualizar estado (5 SP)

| Tarea | Tipo | Responsable | Tiempo est. |
|-------|------|-------------|-------------|
| Crear endpoint `PATCH /inventario/vehiculos/{id}/estado` | Backend | Samuel | 2h |
| Implementar lógica de flujo de estados | Backend | Samuel | 2h |
| Crear botón/modal de cambio de estado en UI | Frontend | Natalia | 2h |
| Registrar historial de cambio de estado | Backend | Samuel | 1h |
| Pruebas del flujo de estados | Pruebas | Juan Gabriel | 1h |

---

### HU-04 — Eliminar vehículo (3 SP)

| Tarea | Tipo | Responsable | Tiempo est. |
|-------|------|-------------|-------------|
| Crear endpoint `DELETE /inventario/vehiculos/{id}` | Backend | Samuel | 1h |
| Validar rol de administrador para eliminar | Backend | Samuel | 1h |
| Botón de eliminar con confirmación en UI | Frontend | Natalia | 1h |
| Pruebas de eliminación y control de roles | Pruebas | Juan Gabriel | 1h |

---

## 5. Plan de Versiones y Ramas

### Flujo de trabajo (Git Flow simplificado)

```
main
 └── dev
      ├── feature/HU-01-registro-vehiculo
      ├── feature/HU-02-consulta-inventario
      ├── feature/HU-03-actualizar-estado
      └── feature/HU-04-eliminar-vehiculo
```

### Convención de nombres de ramas

| Tipo | Formato | Ejemplo |
|------|---------|---------|
| Nueva funcionalidad | `feature/HU-XX-descripcion` | `feature/HU-01-registro-vehiculo` |
| Corrección de bug | `fix/descripcion-corta` | `fix/validacion-vin-duplicado` |
| Documentación | `docs/descripcion` | `docs/actualizar-readme` |
| Hotfix urgente | `hotfix/descripcion` | `hotfix/error-conexion-db` |

### Reglas de Pull Request

- Toda rama `feature/*` hace PR hacia `dev`, **nunca directo a main**
- La PR debe ser aprobada por **al menos 1 compañero** antes de hacer merge
- El título del PR debe referenciar la historia: `[HU-01] Registro de vehículo`
- No se hace merge si las pruebas fallan

---

## 6. Límite de WIP

| Estado | Límite máximo |
|--------|---------------|
| En progreso por persona | 1 tarea a la vez |
| En revisión (PR abierta) | 2 PR simultáneas |
| Bloqueado | Reportar al equipo en menos de 24h |

---

## 7. Criterios de Done (Definition of Done)

Una historia se considera **terminada** cuando cumple **todos** los siguientes puntos:

- [ ] El código está en una rama `feature/HU-XX`
- [ ] El endpoint funciona correctamente en entorno local
- [ ] La UI conecta con el backend sin errores
- [ ] Las pruebas unitarias pasan sin fallar
- [ ] La PR fue revisada y aprobada por al menos 1 compañero
- [ ] Se hizo merge a `dev` sin conflictos
- [ ] El prototipo en Figma refleja los cambios si hubo modificaciones de UI
- [ ] Los diagramas se actualizaron si hubo cambios de arquitectura
- [ ] La funcionalidad fue demostrada en entorno local al equipo

---

## 8. Sprint Backlog — Tablero GitHub Projects

### Columnas recomendadas para el tablero:

| Backlog | En Progreso | En Revisión | Done |
|-----------|---------------|----------------|--------|
| HU-03 Actualizar estado | HU-01 Registrar vehículo | — | — |
| HU-04 Eliminar vehículo | HU-02 Consultar inventario | — | — |

> **Tip:** En GitHub Projects crea una columna por cada estado y arrastra las tarjetas conforme avancen.

---

## 9. Cómo configurar GitHub Projects

1. Ir al repositorio → pestaña **Projects** → **New Project**
2. Seleccionar plantilla **Board** (tablero Kanban)
3. Crear las columnas: `Backlog · En Progreso · En Revisión · Done`
4. Crear una **Issue** por cada historia de usuario (HU-01 a HU-04)
5. Asignar cada Issue al responsable correspondiente
6. Vincular cada PR con su Issue usando `Closes #numero` en la descripción del PR

### Ejemplo de Issue en GitHub:

```
Título: [HU-01] Registrar vehículo en inventario

Descripción:
Como administrador, quiero registrar un nuevo vehículo
con sus datos completos para que quede disponible en el inventario.

Criterios de aceptación:
- [ ] Formulario con campos: VIN, marca, modelo, año, color, precio, km, tipo
- [ ] Estado inicial siempre "disponible"
- [ ] Error si VIN duplicado
- [ ] Vehículo aparece en listado tras guardar

Story Points: 8
Responsable: @Valentina051506
Rama: feature/HU-01-registro-vehiculo
```

---

<div align="center">

**RedMotor ERP · Sprint 1 · Universidad Manuela Beltrán · 2026**

</div>
