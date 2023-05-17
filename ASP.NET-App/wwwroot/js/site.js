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


document.addEventListener("DOMContentLoaded", function () {
    var carousels = document.querySelectorAll(".carousel");
    Array.from(carousels).forEach(function (carousel) {
        carousel.addEventListener("slide.bs.carousel", function () {
            var activeItem = this.querySelector(".carousel-item.active");
            var items = Array.from(this.querySelectorAll(".carousel-item"));

            var activeItemIndex = items.indexOf(activeItem);

            var startIndex = Math.max(activeItemIndex - 1, 0);
            var endIndex = Math.min(startIndex + 6, items.length);

            items.forEach(function (item) {
                item.classList.remove("active");
            });

            for (var i = startIndex; i < endIndex; i++) {
                items[i].classList.add("active");
            }
        });
    });
});