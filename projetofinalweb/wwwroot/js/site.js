// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


const images = document.querySelectorAll('.book-image');

// Adiciona o evento de clique para cada imagem
images.forEach(image => {
    image.addEventListener('click', () => {
        image.classList.toggle('zoomed'); // Alterna a classe 'zoomed'
    });
});