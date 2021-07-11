(function () {

    'use strict'

    var forms = document.querySelectorAll('.needs-validation')

    Array.prototype.slice.call(forms).forEach(function (form) {

        form.addEventListener('submit', function (event) {

            $("input[type='email']").val().toLowerCase();

            $("input[type='password']").keyup(function (event) {

                var alphanumeric = /[.@€₺><*,!#$%&'*+\/=?^_`{|}~-]/g;

                if (!$("input[type='password']").val().match(alphanumeric)) {

                    $("#password > span").html("Lütfen Alphanumeric Karakter<br/>(@-. vb.) Giriniz..")
                    event.preventDefault()
                    event.stopPropagation()
                }


                var lowerCaseLetters = /[a-z]/g;

                if (!$("input[type='password']").val().match(lowerCaseLetters)) {

                    $("#password > span").text("Lütfen Küçük Harf Giriniz..")
                    event.preventDefault()
                    event.stopPropagation()
                }


                var upperCaseLetters = /[A-Z]/g;
                if (!$("input[type='password']").val().match(upperCaseLetters)) {
                    $("#password > span").text("Lütfen Büyük Harf Giriniz..")
                    event.preventDefault()
                    event.stopPropagation()
                }

                var numbers = /[0-9]/g;
                if (!$("input[type='password']").val().match(numbers)) {
                    $("#password > span").text("Lütfen Sayı Giriniz..")
                    event.preventDefault()
                    event.stopPropagation()
                }


                if ($("input[type='password']").val().length < 6) {
                    $("#password > span").text("Lütfen En Az 6 Karakter Giriniz..")
                    event.preventDefault()
                    event.stopPropagation()
                }


                if ($("input[type='password']").val().length == 0) {
                    $("#password > span").text("Bu Alan Zorunludur")
                    event.preventDefault()
                    event.stopPropagation()
                }

            });

            $("input[type='email']").keyup(function (event) {

                var email = /[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$/g;

                if (!$("input[type='email']").val().match(email)) {

                    $("#email > span").text("Lütfen Mail Adresinizi Giriniz..")
                    event.preventDefault()
                    event.stopPropagation()
                }

            });

            if (!form.checkValidity()) {

                if ($("input[type='password']").val().length == 0) {
                    $("#password > span").text("Bu Alan Zorunludur")
                    event.preventDefault()
                    event.stopPropagation()
                } else {

                    var alphanumeric = /[.@€₺><*,!#$%&'*+\/=?^_`{|}~-]/g;

                    if (!$("input[type='password']").val().match(alphanumeric)) {

                        $("#password > span").html("Lütfen Alphanumeric Karakter<br/>(@-. vb.) Giriniz..")
                        event.preventDefault()
                        event.stopPropagation()
                    }


                    var lowerCaseLetters = /[a-z]/g;

                    if (!$("input[type='password']").val().match(lowerCaseLetters)) {

                        $("#password > span").text("Lütfen Küçük Harf Giriniz..")
                        event.preventDefault()
                        event.stopPropagation()

                    }


                    var upperCaseLetters = /[A-Z]/g;
                    if (!$("input[type='password']").val().match(upperCaseLetters)) {
                        $("#password > span").text("Lütfen Büyük Harf Giriniz..")
                        event.preventDefault()
                        event.stopPropagation()
                    }

                    var numbers = /[0-9]/g;
                    if (!$("input[type='password']").val().match(numbers)) {
                        $("#password > span").text("Lütfen Sayı Giriniz..")
                        event.preventDefault()
                        event.stopPropagation()
                    }


                    if ($("input[type='password']").val().length < 6) {
                        $("#password > span").text("Lütfen En Az 6 Karakter Giriniz..")
                        event.preventDefault()
                        event.stopPropagation()
                    }


                    if ($("input[type='password']").val().length == 0) {
                        $("#password > span").text("Bu Alan Zorunludur")
                        event.preventDefault()
                        event.stopPropagation()
                    }

                }

                if ($("input[type='email']").val().length == 0) {
                    $("#email > span").text("Bu Alan Zorunludur")
                    event.preventDefault()
                    event.stopPropagation()
                } else {

                    $("#email > span").text("Lütfen Mail Adresinizi Giriniz")
                    event.preventDefault()
                    event.stopPropagation()

                }


                event.preventDefault()
                event.stopPropagation()

            }

            form.classList.add('was-validated')

        }, false)

    })

})()