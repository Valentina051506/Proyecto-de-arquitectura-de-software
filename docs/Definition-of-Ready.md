# Definition of Ready (DoR) — RedMotor ERP

Una historia de usuario está **lista para iniciar desarrollo** cuando cumple TODOS estos puntos:

---

## Checklist DoR

- [ ] La historia tiene un usuario identificado y un valor de negocio claro
- [ ] Los criterios de aceptación están escritos en formato Gherkin (Dado / Cuando / Entonces)
- [ ] El wireframe o prototipo en Figma está enlazado en la Issue
- [ ] El diagrama PlantUML inicial (componente o secuencia) está disponible
- [ ] Los datos de prueba están definidos
- [ ] La estimación en story points fue acordada en Planning Poker
- [ ] La historia está vinculada al Sprint y al Milestone correspondiente
- [ ] El responsable fue asignado en GitHub Projects

---

## Formato Gherkin

```
Dado que [contexto inicial]
Cuando [acción del usuario]
Entonces [resultado esperado]
Y [resultado adicional si aplica]
```

---

## Ejemplo aplicado — HU-01

```
Dado que estoy en el formulario de nuevo vehículo
Cuando ingreso VIN, marca, modelo, año, color, precio, kilometraje y tipo válidos
Entonces el sistema guarda el vehículo con estado 'disponible'
Y lo muestra en el listado de inventario
```

---

> Si la historia NO cumple el DoR, regresa al Backlog para refinamiento antes de moverla a **To Do**.
