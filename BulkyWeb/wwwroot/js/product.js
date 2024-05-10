let dataTable;
$(document).ready(function () {
    LoadDataTable();
});
function LoadDataTable() {
    dataTable = $('#tbldata').DataTable({
        "ajax": '/admin/product/getall',
        "columns": [
            { data: 'author' },
            { data: 'title', "width": '25%' },
            { data: 'listPrice', "width": '15%' },
            { data: 'category.name', "width": '15%' },
            { data: 'isbn', "width": '15%' },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="btn-group" style="min-width: 150px;">
                        <a href="/Admin/Product/Upsert/${data}" class="btn btn-success" >
                            <i class="bi bi-pencil"></i>
                            Edit
                        </a>
                        <a onClick=Delete('/Admin/Product/Delete/${data}') class="btn btn-danger" >
                            <i class="bi bi-trash"></i>
                                Delete
                        </a>
                    </div>`
                },
                "width": '15%'
            }
        ]
    },
    );
}
console.log(dataTable)
function Delete(url) {
    Swal.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                        Swal.fire({
                            title: "Deleted!",
                            text: "Your product has been deleted.",
                            icon: "success"
                        });
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            })
        } else {
            Swal.fire({
                title: "Cancelled",
                text: "Your product is safe :)",
                icon: "error"
            });
        }
    });
}
