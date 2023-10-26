$(document).ready(function () {
    $('#RegistoCarros').DataTable(
        {
            language: {
                "decimal": "",
                "emptyTable": "No data available in table",
                "info": "Mostrar _START_ a  _END_ de _TOTAL_ registos",
                "infoEmpty": "Mostrar 0 a 0 de 0 registos",
                "infoFiltered": "(filtrado de _MAX_ total registos)",
                "infoPostFix": "",
                "thousands": ",",
                "lengthMenu": "Mostrar _MENU_ registos",
                "loadingRecords": "Carregando...",
                "processing": "",
                "search": "Procurar:",
                "zeroRecords": "Nennum registo encontrado",
                "paginate": {
                    "first": "Primeiro",
                    "last": "Último",
                    "next": "Próximo",
                    "previous": "Anterior"
                },
                "aria": {
                    "sortAscending": ": activate to sort column ascending",
                    "sortDescending": ": activate to sort column descending"
                }
            }
        }    );
});