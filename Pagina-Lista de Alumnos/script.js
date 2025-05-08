var Url = "https://681c48d86ae7c794cf713d77.mockapi.io/Alumnos";


window.onload = function() {
    getAlumnos();
};


function getAlumnos() {
    fetch(Url)
        .then(function(respuesta) {
            if (respuesta.ok) {
                return respuesta.json();
            } else {
                alert("Error al cargar alumnos");
            }
        })
        .then(function(datos) {
            showLista(datos);
        })
        .catch(function() {
            alert("Error al cargar alumnos");
        });
}


function showLista(datos) {
    var lista = document.getElementById("listaAlumnos");
    lista.innerHTML = ""; 

    for (var i = 0; i < datos.length; i++) {
        var nombre = datos[i].Nombre;
        var apellido = datos[i].Apellido;
        var curso = datos[i].Curso;
        var id = datos[i].id;

        var nuevoLi = document.createElement("li");
        nuevoLi.innerText = "ID: " + id + " | Nombre: " + nombre + " | Apellido: " + apellido + " | Curso: " + curso;
        lista.appendChild(nuevoLi);
    }
}


function addAlumno() {
    var nom = document.getElementById("nombreNuevo").value;
    var ape = document.getElementById("apellidoNuevo").value;
    var cur = document.getElementById("cursoNuevo").value;

    if (nom == "" || ape == "" || cur == "") {
        alert("Faltan datos!");
        return;
    }

    var objeto = {
        Nombre: nom,
        Apellido: ape,
        Curso: cur
    };

    fetch(Url, {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(objeto)
    })
    .then(function(respuesta) {
        if (respuesta.ok) {
            alert("Alumno agregado!");
            getAlumnos(); 
        } else {
            alert("Error al agregar");
        }
    })
    .catch(function() {
        alert("Error al agregar");
    });
}


function updateAlumno() {
    var id = document.getElementById("updateId").value;
    var nom = document.getElementById("nombreMod").value;
    var ape = document.getElementById("apellidoMod").value;
    var cur = document.getElementById("cursoMod").value;

    if (id == "" || nom == "" || ape == "" || cur == "") {
        alert("Faltan datos!");
        return;
    }

    var objeto = {
        Nombre: nom,
        Apellido: ape,
        Curso: cur
    };

    fetch(Url + "/" + id, {
        method: "PUT",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(objeto)
    })
    .then(function(respuesta) {
        if (respuesta.ok) {
            alert("Alumno modificado!");
            getAlumnos(); 
            document.getElementById("updateId").value = "";
            document.getElementById("nombreMod").value = "";
            document.getElementById("apellidoMod").value = "";
            document.getElementById("cursoMod").value = "";
        } else {
            alert("Error al modificar");
        }
    })
    .catch(function() {
        alert("Error al modificar");
    });
}


function deleteAlumno() {
    var id = document.getElementById("deleteId").value;

    if (id == "") {
        alert("Falta el ID!");
        return;
    }

    fetch(Url + "/" + id, {
        method: "DELETE"
    })
    .then(function(respuesta) {
        if (respuesta.ok) {
            alert("Alumno eliminado!");
            getAlumnos(); 
        } else {
            alert("Error al eliminar");
        }
    })
    .catch(function() {
        alert("Error al eliminar");
    });
}