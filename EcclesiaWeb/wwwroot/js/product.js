$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    $('#tblData').DataTable({
        "ajax": {
            "url": "/admin/product/getall",
            "type": "GET",
            "datatype": "json",
            "dataSrc": "data"
        },
        "columns": [
            { "data": "title", "width": "15%" },
            { "data": "isbn", "width": "15%" },
            { "data": "listPrice", "width": "15%" },
            { "data": "category.name", "width": "15%" },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="text-center">
                                <a href="/Admin/Product/Upsert?id=${data}" class="btn btn-success text-white" style="cursor:pointer">
                                    <i class="bi bi-pencil-square"></i>
                                </a>
                                &nbsp;
                                <a onclick="deleteProduct(${data})" class="btn btn-danger text-white" style="cursor:pointer">
                                    <i class="bi bi-trash3"></i>
                                </a>
                            </div>`;
                }, "width": "15%"
            }
        ]
    });
}

function deleteProduct(id) {
    if (confirm('Are you sure you want to delete this product?')) {
        $.ajax({
            type: "POST",
            url: `/Admin/Product/Delete/${id}`,
            success: function (data) {
                if (data.success) {
                    alert('Product deleted successfully.');
                    $('#tblData').DataTable().ajax.reload();
                } else {
                    alert('Error while deleting: ' + data.message);
                }
            },
            error: function (xhr, status, error) {
                alert('An error occurred: ' + error);
                console.error("Status: " + status + ", Error: " + error);
            }
        });
    }
}
