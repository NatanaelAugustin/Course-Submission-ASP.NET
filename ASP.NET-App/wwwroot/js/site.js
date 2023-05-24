function footerPosition(element, scrollHeight, innerHeight) {
    try {
        const _element = document.querySelector(element)
        const isTallerThanScreen = scrollHeight >= (innerHeight + _element.scrollHeight)

        _element.classList.toggle('position-fixed-bottom', !isTallerThanScreen)
        _element.classList.toggle('position-static', isTallerThanScreen)
    } catch { }
}
footerPosition('footer', document.body.scrollHeight, window.innerHeight)


function toggleMenu(attribute) {
    try {
        const toggleBtn = document.querySelector(attribute)
        toggleBtn.addEventListener('click', function () {
            const element = document.querySelector(toggleBtn.getAttribute('data-target'))

            if (!element.classList.contains('open-menu')) {
                element.classList.add('open-menu')
                toggleBtn.classList.add('btn-outline-dark')
                toggleBtn.classList.add('btn-toggle-white')
            }

            else {
                element.classList.remove('open-menu')
                toggleBtn.classList.remove('btn-outline-dark')
                toggleBtn.classList.remove('btn-toggle-white')
            }
        })
    } catch { }
}
toggleMenu('[data-option="toggle"]')

const validateEmail = (event) => {
    const regEx = /^[^\s@]+@[^\s@]+\.[^\s@]+$/
    if (regEx.test(event.target.value)) {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = ""

    } else
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "Invalid email"
}

const validatePassword = (event) => {
    const regEx = /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])[0-9a-zA-Z]{8,}$/
    if (regEx.test(event.target.value)) {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = ""

    } else
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "Invalid password"

}

const validateText = (event) => {
    if (event.target.value.length >= 2) {
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = ""

    } else
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "Invalid length"
}

// Smooth carousel navigation
var carouselElements = document.querySelectorAll('.carousel');
carouselElements.forEach(function (carouselElement) {
    new bootstrap.Carousel(carouselElement, {
        interval: 5000,
        wrap: true,
        pause: 'hover',
    });
});