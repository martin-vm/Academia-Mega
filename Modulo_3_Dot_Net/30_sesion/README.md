# termicoMega

**termicoMega** es un servicio desarrollado con .NET 9.0 para monitorear sensores térmicos del sistema utilizando [LibreHardwareMonitor](https://github.com/LibreHardwareMonitor/LibreHardwareMonitor), con capacidades de registro (logging) mediante **Serilog** y observabilidad gracias a **OpenTelemetry**. 

---

## 🚀 Características

- Lectura de sensores de temperatura (CPU, GPU, motherboard, etc.)
- Registro estructurado a consola y archivo usando Serilog
- Observabilidad con OpenTelemetry

---

## 🛠 Tecnologías utilizadas

- [.NET 9.0 Worker Service](https://learn.microsoft.com/en-us/dotnet/core/extensions/workers)
- [LibreHardwareMonitorLib 0.9.4](https://github.com/LibreHardwareMonitor/LibreHardwareMonitor)
- [Serilog](https://serilog.net/) (console + file sinks)
- [OpenTelemetry](https://opentelemetry.io/)
- `System.Diagnostics.EventLog` (soporte para eventos de Windows)

---

## 📦 Instalación

1. Clona el repositorio:

   ```bash
   git clone https://github.com/martin-vm/termicoMega.git
   cd termicoMega
