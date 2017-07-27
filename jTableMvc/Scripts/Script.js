$(document).ready(function () {
    $('#Tabla').jtable({
        title: 'Clientes',
        selecting: true, //Enable selecting 
        paging: true, //Enable paging
        pageSize: 10, //Set page size (default: 10)
        sorting: true, //Enable sorting
        actions: {
          listAction: '@Url.Action("getClientes","Clientes")',
            createAction: '/Clientes/Create',
            updateAction: '/Clientes/Edit',
            deleteAction: '/Clientes/Delete'
        },
        fields: {
            Nombre: {
                title: 'Nombre',
                width: '15%'
            },
            Apellido: {
                title: 'Apellido',
                width: '45%'
            },
            Nacimiento: {
                title: 'Nacimiento',
                width: '15%',
            },
            Cedula: {
                title: 'Cedula',
                width: '15%',
            }
        }
    });
    $('#Tabla').jtable('load');
});