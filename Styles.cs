body {
    font-family: Arial, sans-serif;
    margin: 0;
    padding: 0;
}
.nav {
    position: fixed;
    top: 0;
    left: 0;
    width: 100%;
    background-color: #333;
    color: #fff;
    padding: 1em;
    display: flex;
    justify-content: space-between;
    align-items: center;
    transition: background-color 0.5s ease;
}
.nav-logo {
    font-size: 1.5em;
    margin-right: 1em;
}
.nav-menu {
    list-style: none;
    margin: 0;
    padding: 0;
    display: flex;
}
.nav-item {
    margin-right: 1em;
}
.nav-link {
    color: #fff;
    text-decoration: none;
    transition: color 0.5s ease;
}

.nav-link:hover {
    color: #ccc;
}
.header {
    background-image: linear-gradient(to bottom, #333, #555);
    background-size: 100% 300px;
    background-position: 0% 100%;
    height: 100vh;
    display: flex;
    justify-content: center;
    align-items: center;
    color: #fff;
}
.header h1 {
    font-size: 3em;
}
.header p {
    font-size: 1.5em;
}
button {
    background-color: #333;
    color: #fff;
    border: none;
    padding: 1em 2em;
    font-size: 1em;
    cursor: pointer;
}
button:hover {
    background-color: #555;
}
/* Scroll effect */
.nav.scrolled {
    background-color: #555;
}
.nav.scrolled .nav-link {
    color: #fff;
}
.nav.scrolled .nav-link:hover {
  color: #ccc;
}
