const nav =
document.querySelector('.nav');
window.addEventListe ner('scroll', () =>
  {
if (window.scrolly > 50) {
.classList.add('scrolled');
} else { nav.classList.remove('s crolled');
  }
});
