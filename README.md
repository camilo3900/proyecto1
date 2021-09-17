# UC PARKING

Repo de la entrega de la segunda semana

## Nota

tener en cuenta de que en

`Parking_app.App\Parking_app.App.Persistent\AppRepo\AppContext.cs`

la sentencia de:

`.UseSqlServer("Initial Catalog = ParkingApp.Data; Data Source=LAPTOP-VPO7HRDD\\SQLEXPRESS; Integrated Security=true");`

el argumento `Data Source=` hace referencia al nombre de la base de datos local asi que para evitar problemas al generar la migración reemplazar el valor por el nombre de la base de datos local de cada uno de forma local.
