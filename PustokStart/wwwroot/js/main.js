let modalBtn = document.querySelectorAll(".modal-btn")
modalBtn.forEach((btn) => {
    btn.addEventListener("click", (e) => {
        e.preventDefault()
       
        let url = btn.getAttribute("href")

        fetch(url)
            .then(responce => responce.text())
            .then(data => {
                $("#quickModal .modal-dialog").html(data)
                $("#quickModal").modal("show")
            })
    })
})


