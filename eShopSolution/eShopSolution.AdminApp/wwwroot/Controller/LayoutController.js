// Logout
$(document).ready(function () {
    $('#aLogout').click(function () {
        $.ajax({
            url: "/user/logout",
            type: "GET",
            success: function () {
                window.location.href = "/login/index";
            },
            error: function () {
                Swal.fire({
                    icon: 'error',
                    title: 'Error',
                    text: 'Logout fail'
                });
            },
        });
        window.sessionStorage.removeItem("Token");
    });
});