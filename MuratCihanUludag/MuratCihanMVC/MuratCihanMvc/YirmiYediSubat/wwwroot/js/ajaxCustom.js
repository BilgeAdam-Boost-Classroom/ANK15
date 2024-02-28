
$("#successBtn").click(() => {
    var id = $("#OgrenciId").val();
    $.ajax({
        url: `/home/index2/${id}`,
        method: "GET",
        dataType: "JSON",
        contentType: "application/JSON;charset=utf-8",
        success: (data) => {
            $(".index-2").html(`<p>${data.ad} ${data.soyad}</p>`)
        },
        error: (xhr, status, error) => {
            console.log(xhr.status)
        }
    })
})

$(document).ready(() => {
    $.ajax({
        url: `malzeme/GetTableList`,
        method: "GET",
        beforeSend: () => {
            $(".table-container").html(`<img class="text-center" src="./img/loading.gif" />`)
        },
        success: (data) => {
            $(".table-container").html(data)
        },
        error: (xhr) => {
            confirm.log(xhr.status)
        }

    })

})


$("#table-btn-2").click(() => {

    $.ajax({
        url: `malzeme/Listeleme`,
        method: "GET",
        dataType: "JSON",
        contentType: "application/JSON;charset=urf-8",
        //beforeSend: () => {
        //    $(".table-container").html(`<img class="text-center" src="./img/loading.gif" />`)
        //},
        success: (datas) => {

            //console.log(datas)
            $.each(datas, (i, data) => {
                let satir = `
                <tr>
                    <td>${data.ad}</td>
                    <td>${data.fiyat} </td>
                </tr>
                `
                console.log(satir)
                //$("#Buraya id ver").append(satir)

            })
            //$(".table-container").html(datas)
        },
        error: (xhr) => {
            confirm.log(xhr.status)
        }
    })

})


$("#table-btn").click(() => {
    $.ajax({
        url: `malzeme/GetTableList`,
        method: "GET",
        beforeSend: () => {
            $(".table-container").html(`<img class="text-center" src="./img/loading.gif" />`)
        },
        success: (data) => {
            $(".table-container").html(data)
        },
        error: (xhr) => {
            confirm.log(xhr.status)
        }
    })
})

$("#btn-malzeme-add").click(() => {

    var formData = Object.fromEntries(new FormData($("#form-malzeme")[0]).entries());

    console.log(formData)

    $.ajax({
        url: `malzeme/Add`,
        method: "POST",
        data: formData,
        beforeSend: () => {

        },
        success: () => {
            $("#table-btn").click()
        }
    })
})
function Delete(id) {
    $.ajax({
        url: `malzeme/delete/${id}`,
        method: "POST",
        success: () => {
            $("#table-btn").click()
        }
    })
}
