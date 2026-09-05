document.addEventListener("DOMContentLoaded", function () {

    // Navbar shadow while scrolling

    const navbar = document.querySelector(".navbar-wrapper");

    window.addEventListener("scroll", function () {

        if (window.scrollY > 30) {

            navbar.classList.add("navbar-scrolled");

        } else {

            navbar.classList.remove("navbar-scrolled");

        }

    });


    // Close mobile navigation after clicking a link

    const navLinks =
        document.querySelectorAll(".navbar-nav .nav-link");

    const navbarCollapse =
        document.querySelector(".navbar-collapse");


    navLinks.forEach(function (link) {

        link.addEventListener("click", function () {

            if (navbarCollapse.classList.contains("show")) {

                bootstrap.Collapse
                    .getInstance(navbarCollapse)
                    ?.hide();

            }

        });

    });

});