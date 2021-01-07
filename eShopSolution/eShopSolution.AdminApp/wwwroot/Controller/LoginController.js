// Save url in sessionStorage
$(document).ready(function () {
    var urlApi = "https://localhost:5001";
    window.sessionStorage.setItem("urlApi", btoa(urlApi));
    $('#btnLogin').click(function () {
        frmLoginValidate();
        if ($('#frmLogin').valid())
            login();
    });
    $('.bg-primary').keypress(function (e) {
        if (e.which == 13)
            frmLoginValidate();
            if ($('#frmLogin').valid())
                login();
    });
});

// validate
var frmLoginValidate = function () {
    $('#frmLogin').validate({
        rules: {
            txtUserName: {
                required: true,
                maxlength: 200,
            },
            txtPassword: {
                required: true,
                maxlength: 200,
                minlength: 6,
            }
        },
        messages: {
            txtUserName: {
                required: "Tên đăng nhập trống",
                maxlength: "Tên đăng nhập không quá 200 ký tự"
            },
            txtPassword: {
                required: "Mật khẩu trống",
                maxlength: "Mật khẩu không quá 200 ký tự",
                minlength: "Mật khẩu ít nhất là 6 ký tự",
            }
        }
    });
};

// Login
var login = function () {
    var data = {
        "UserName": $('#txtUserName').val(),
        "Password": $('#txtPassword').val()
    };
    $.ajax({
        url: atob(window.sessionStorage.getItem("urlApi")) + "/api/users/login",
        type: "POST",
        data: JSON.stringify(data),
        dataType: "json",
        contentType: "application/json",
        success: function (response) {
            var token = response.entity;
            window.sessionStorage.setItem("Token", token);
            $.ajax({
                url: "/login/loginaction",
                type: "POST",
                headers: {
                    "Authorization": token
                },
                success: function () {
                    window.location.href = "/home/index";
                },
                error: function () {
                    Swal.fire({
                        icon: 'error',
                        title: 'Error',
                        text: 'Login Fail'
                    });
                },
            });
        },
        error: function (response) {
            Swal.fire({
                icon: 'error',
                title: 'Error',
                text: JSON.stringify(response.responseJSON.message)
            });
        }
    });
};
