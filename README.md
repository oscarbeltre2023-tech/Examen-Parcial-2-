Cafetería El Buen Sabor - Sistema de Pedidos

Nombre y Matrícula
Nombre: Oscar Daniel Beltre Peguero
Matrícula: 2025-1651

Descripción del Programa
Aplicación de escritorio desarrollada en C# (Windows Forms) para gestionar los pedidos de la *Cafetería El Buen Sabor*[span_1](start_span)[span_1](end_span)[span_2](start_span)[span_2](end_span). Permite agregar productos al detalle de compra con sus respectivos recargos por tamaño o porción extra, aplicar descuentos a clientes frecuentes, sumar el cargo de empaque para llevar y calcular automáticamente el ITBIS (18%) y el total a pagar[span_3](start_span)[span_3](end_span).

Datos de Entrada
Cliente: Nombre del cliente (`txtCliente`)[span_4](start_span)[span_4](end_span).
Cliente frecuente: Selección booleana mediante casilla (`chkFrecuente`)[span_5](start_span)[span_5](end_span).
Fecha: Fecha del pedido (`dtpFecha`)[span_6](start_span)[span_6](end_span).
Producto y Precio: Nombre del artículo (`txtProducto`) y precio base (`txtPrecio`)[span_7](start_span)[span_7](end_span).
Cantidad: Unidades solicitadas (`nudCantidad`)[span_8](start_span)[span_8](end_span).
Opciones del producto: Tamaño Normal o Grande (+RD$25) (`rbtNormal`, `rbtGrande`) y Porción extra (+RD$30) (`chkPorcionExtra`)[span_9](start_span)[span_9](end_span).
Tipo de servicio: Consumir en local o Para llevar (+RD$20 de empaque) (`rbtLocal`, `rbtLlevar`)[span_10](start_span)[span_10](end_span).

Proceso
1. Agregar al pedido (`btnAgregar`):** Toma el precio base, suma RD$25 si el tamaño es Grande y RD$30 si incluye porción extra, multiplica por la cantidad para obtener el total de la línea y lo añade a la lista de pedidos (`lstPedido`)[span_11](start_span)[span_11](end_span).
Calcular total (`btnCalcular`):** Suma el subtotal de todos los productos agregados, aplica un 10% de descuento si es cliente frecuente, suma RD$20 de empaque si el servicio es para llevar, calcula el 18% de ITBIS sobre la base imponible y determina el monto final[span_12](start_span)[span_12](end_span).
Nuevo pedido (`btnLimpiar`) y Salir (`btnSalir`):** Reinician los campos para un nuevo registro o cierran la aplicación previa confirmación[span_13](start_span)[span_13](end_span).

Salida
Detalle del pedido (`lstPedido`): Listado con cantidad, producto, precio unitario ajustado y total por ítem[span_14](start_span)[span_14](end_span).
Resumen de montos: Visualización formateada en moneda local (`RD$`) de Subtotal (`lblSubtotal`), Descuento (`lblDescuento`), Empaque (`lblEmpaque`), ITBIS 18% (`lblItbis`) y Total a pagar (`lblTotal`)[span_15](start_span)[span_15](end_span).
