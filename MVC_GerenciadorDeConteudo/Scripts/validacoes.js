var ValidaExclusao = function (id, evento) {
    if (confirm("Confirmna a exclusão?")) {
        return true;
    }
    else {
        evento.preventDefault();
        return false;
    }
}