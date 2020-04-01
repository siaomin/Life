function DeleteGuest(Id) {
    $.ajax({
        type: 'POST',
        url: '../Guest/RemoveGuest',
        contentType: 'application/json; charset=utf-8',
        async: false,
        dataType: 'JSON',
        data: JSON.stringify({ Id: Id }),
        success: function (result) {
            window.location.href = result;
        },
        error: function (xhr) {
            alert(xhr.responseText);
        }
    });
}