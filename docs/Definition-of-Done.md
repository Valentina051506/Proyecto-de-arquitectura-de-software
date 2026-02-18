# 🏁 Definition of Done (DoD) — RedMotor ERP

Una historia de usuario está **terminada** cuando cumple TODOS estos puntos:

---

## Checklist DoD

- [ ] El código está en una rama `feature/HU-XX-descripcion`
- [ ] La Pull Request fue aprobada por al menos 1 compañero
- [ ] El merge a `dev` se realizó sin conflictos
- [ ] Las pruebas unitarias pasan sin errores
- [ ] Los criterios de aceptación fueron verificados con una demo en entorno local
- [ ] El prototipo en Figma fue actualizado si hubo cambios en la UI
- [ ] Los diagramas PlantUML fueron actualizados si hubo cambios de arquitectura
- [ ] La documentación técnica del endpoint o componente está en el repositorio
- [ ] La historia fue movida a la columna **Done** en GitHub Projects

---

## Checklist de Pull Request

Cada PR debe incluir en su descripción:

```markdown
## ¿Qué hace esta PR?
Breve descripción del cambio.

## Historia relacionada
Closes #NUMERO_ISSUE

## Checklist
- [ ] El código compila sin errores
- [ ] Las pruebas pasan
- [ ] Los criterios de aceptación fueron verificados
- [ ] Figma actualizado (si aplica)
- [ ] Diagramas actualizados (si aplica)
- [ ] Demo realizada en local
```

---

## Convención de commits

```
feat(HU-01): agregar formulario de registro de vehículo
fix(HU-02): corregir filtro de búsqueda por VIN
docs(HU-03): actualizar diagrama de secuencia de estados
refactor(HU-04): separar lógica de eliminación en servicio
```

---

> ⚠️ Si la historia NO cumple el DoD, NO se mueve a **Done** aunque el tiempo del Sprint haya terminado.
