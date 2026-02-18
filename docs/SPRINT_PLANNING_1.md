# Sprint Planning 1 — RedMotor ERP
## Módulo: Gestión de Inventario de Vehículos

**Fecha:** Febrero 2026
**Duración:** 2 semanas
**Equipo:** Natalia Valentina Omaña · Juan Gabriel Gutiérrez · Samuel Ossa
**Herramienta:** GitHub Projects

---

## 1. Objetivo del Sprint

> **"Implementar el módulo de Inventario de Vehículos con registro, consulta y actualización de estado, validado con pruebas unitarias y desplegado en entorno local."**

| Al finalizar el Sprint se podrá... |
|------------------------------------|
| Registrar un vehículo nuevo con todos sus atributos |
| Consultar el inventario completo y filtrar por estado |
| Cambiar el estado de un vehículo (disponible → reservado → vendido) |
| Eliminar un vehículo con estado "disponible" |

---

## 2. Sprint Backlog — Historias seleccionadas

| ID | Historia | Prioridad | SP | Estado |
|----|----------|-----------|----|--------|
| HU-01 | Registrar vehículo en inventario | Alta | 8 | To Do |
| HU-02 | Consultar inventario de vehículos | Alta | 5 | To Do |
| HU-03 | Actualizar estado del vehículo | Alta | 5 | To Do |
| HU-04 | Eliminar vehículo del inventario | Alta | 3 | To Do |
| | **TOTAL SPRINT** | | **21 SP** | |

### Backlog futuro (Sprint 2)

| ID | Historia | Prioridad | SP |
|----|----------|-----------|----|
| HU-05 | Alerta de vehículos sin movimiento | Media | 8 |
| HU-06 | Reporte de rotación de inventario | Baja | 5 |

---

## 3. Planning Poker — Estimación

**Escala Fibonacci:** 1 · 2 · 3 · 5 · 8 · 13 · 21

| ID | Historia | Justificación | SP |
|----|----------|---------------|----|
| HU-01 | Registrar vehículo | Formulario complejo + validaciones + API + BD | **8** |
| HU-02 | Consultar inventario | Listado + filtros múltiples + búsqueda | **5** |
| HU-03 | Actualizar estado | Lógica de flujo de estados + historial | **5** |
| HU-04 | Eliminar vehículo | CRUD básico con validación de rol | **3** |

---

## 4. Desglose Técnico por Historia

### HU-01 — Registrar vehículo (8 SP)

| Tarea | Tipo | Responsable | Tiempo |
|-------|------|-------------|--------|
| Crear entidad `Vehiculo` y repositorio JPA | Backend | Samuel | 2h |
| Crear endpoint `POST /inventario/vehiculos` | Backend | Samuel | 2h |
| Validaciones + manejo de errores (VIN duplicado) | Backend | Samuel | 1h |
| Crear formulario de registro en React | Frontend | Natalia | 3h |
| Conectar formulario con API REST | Frontend | Natalia | 1h |
| Pruebas unitarias del endpoint | Pruebas | Juan Gabriel | 2h |
| Documentar endpoint en `/docs` | Docs | Juan Gabriel | 1h |

---

### HU-02 — Consultar inventario (5 SP)

| Tarea | Tipo | Responsable | Tiempo |
|-------|------|-------------|--------|
| Endpoint `GET /inventario/vehiculos` con filtros | Backend | Samuel | 2h |
| Implementar filtro por estado y búsqueda por VIN | Backend | Samuel | 1h |
| Tabla de inventario en React | Frontend | Natalia | 3h |
| Filtros y buscador en UI | Frontend | Natalia | 2h |
| Pruebas de integración del listado | Pruebas | Juan Gabriel | 1h |

---

### HU-03 — Actualizar estado (5 SP)

| Tarea | Tipo | Responsable | Tiempo |
|-------|------|-------------|--------|
| Endpoint `PATCH /inventario/vehiculos/{id}/estado` | Backend | Samuel | 2h |
| Lógica de flujo de estados + historial | Backend | Samuel | 2h |
| Modal de cambio de estado en UI | Frontend | Natalia | 2h |
| Pruebas del flujo de estados | Pruebas | Juan Gabriel | 1h |

---

### HU-04 — Eliminar vehículo (3 SP)

| Tarea | Tipo | Responsable | Tiempo |
|-------|------|-------------|--------|
| Endpoint `DELETE /inventario/vehiculos/{id}` | Backend | Samuel | 1h |
| Validar rol administrador para eliminar | Backend | Samuel | 1h |
| Botón eliminar con confirmación en UI | Frontend | Natalia | 1h |
| Pruebas de eliminación y control de roles | Pruebas | Juan Gabriel | 1h |

---

## 5. 🚦 Límite de WIP

| Columna | Límite WIP | Color |
|---------|------------|-------|
| Backlog | Sin límite | ⚪ Gris |
| To Do | Sin límite | 🔵 Azul |
| In Progress | **3 tareas máx.** | 🟡 Amarillo |
| In Review | **2 PRs máx.** | 🟠 Naranja |
| Testing | **2 tareas máx.** | 🟣 Morado |
| Done | Sin límite | 🟢 Verde |

> Si alguien está bloqueado debe reportarlo al equipo en menos de **24 horas**.

---

## 6. Plan de Versiones y Ramas

### Estructura de ramas

```
main          ← Versión estable y revisada
 └── dev      ← Integración continua del Sprint
      ├── feature/HU-01-registro-vehiculo
      ├── feature/HU-02-consulta-inventario
      ├── feature/HU-03-actualizar-estado
      └── feature/HU-04-eliminar-vehiculo
```

### Convención de nombres

| Tipo | Formato | Ejemplo |
|------|---------|---------|
| Nueva funcionalidad | `feature/HU-XX-descripcion` | `feature/HU-01-registro-vehiculo` |
| Corrección de bug | `fix/descripcion-corta` | `fix/validacion-vin-duplicado` |
| Documentación | `docs/descripcion` | `docs/actualizar-diagramas` |
| Hotfix urgente | `hotfix/descripcion` | `hotfix/error-conexion-db` |

### Convención de commits

```
feat(HU-01): agregar formulario de registro de vehículo
fix(HU-02): corregir filtro de búsqueda por VIN
docs(HU-03): actualizar diagrama de secuencia de estados
refactor(HU-04): separar lógica de eliminación en servicio
```

### Reglas de Pull Request

- Toda rama `feature/*` hace PR hacia `dev`, **nunca directo a main**
- La PR debe ser aprobada por **al menos 1 compañero**
- El título del PR referencia la historia: `[HU-01] Registro de vehículo`
- No se hace merge si las pruebas fallan

---

## 7. Criterios de Done por Historia

Una historia está **terminada** cuando cumple TODOS estos puntos:

- [ ] Código en rama `feature/HU-XX` sin conflictos
- [ ] PR aprobada por al menos 1 compañero
- [ ] Merge a `dev` realizado correctamente
- [ ] Pruebas unitarias pasan sin errores
- [ ] Criterios de aceptación verificados en demo local
- [ ] Figma actualizado si hubo cambios en UI
- [ ] Diagramas PlantUML actualizados si hubo cambios de arquitectura
- [ ] Documentación técnica en `/docs`
- [ ] Historia movida a **Done** en GitHub Projects

---

## 8. Plan de las 2 Semanas

| Día | Actividad | Entregable |
|-----|-----------|------------|
| Día 1 | Sprint Planning + configurar GitHub Projects | Tablero listo, Issues creadas |
| Días 2-3 | Diseño UI en Figma + diagramas PlantUML | Wireframes y diagramas listos |
| Días 4-7 | Desarrollo HU-01 y HU-02 | PRs abiertas hacia dev |
| Días 8-10 | Desarrollo HU-03 y HU-04 | PRs abiertas hacia dev |
| Días 11-12 | Pruebas + QA + corrección de bugs | Todas las historias en Done |
| Día 13 | Sprint Review — Demo funcional | Demo grabada o presentada |
| Día 14 | Retrospectiva | Acciones de mejora documentadas |

---

## 9. Configuración del Tablero en GitHub Projects

### Columnas del tablero

```
Backlog → To Do → In Progress → In Review → Testing → Done
```
---

## 🔗 Enlaces del Proyecto

- [Repositorio GitHub](https://github.com/Valentina051506/Proyecto-de-arquitectura-de-software)
- [Prototipo Figma](https://www.figma.com/make/PieMlqJSy6aayMBCZiiLbm/Automotive-ERP-UI-Design-System?p=f&fullscreen=1)
- [Definition of Ready](./Definition-of-Ready.md)
- [Definition of Done](./Definition-of-Done.md)
- [Backlog CSV](./sprint1-backlog.csv)

---

<div align="center">

**RedMotor ERP · Sprint 1 · Universidad Manuela Beltrán · 2026**

</div>
