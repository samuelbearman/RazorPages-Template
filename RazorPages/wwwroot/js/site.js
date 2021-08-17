var Dynamic = (function () {

    function init() {
        $('#load').on('click', function (evt) {
            evt.preventDefault();

            let data = $('#formData').serialize();

            $.ajax({
                type: "POST",
                headers: { "RequestVerificationToken": $('input[name="__RequestVerificationToken"]').val() },
                url: 'dynamic?handler=AddItem',
                contentType: 'application/x-www-form-urlencoded; charset=utf-8',
                data: data,
                success: function (data) {
                    $('#itemsContainer').html(data)
                },
                error: function (xhr, ajaxOptions, thrownError) {
                    console.log(thrownError)
                }
            })
        });
    }

    return {
        init: init
    };

})();