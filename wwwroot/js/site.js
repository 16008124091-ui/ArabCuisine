// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener("DOMContentLoaded", function () {
    const searchInput = document.getElementById("searchInput");
    if (!searchInput) return;

    searchInput.addEvenListener("keyup", function () {
        const value = this.value.toLowerCase();
        const cards = documents.querySelectorAll(".country-card");

        cards.forEach(card => {
            const name = card.getAttribute("data-name");
            card.style.display = name.includes(value) ? "block" : "none";

        });
    });
});