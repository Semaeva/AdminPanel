
    document.addEventListener('click', function (e) {
        document.getElementById('myDIV').value = '';

    names = ''
    e = e || window.event;
    var target = e.target;
    text = target.textContent || target.innerText;
    names = e.target.querySelector('.fc-event-title');
    const para = document.createElement("p");
    para.setAttribute("id", "para");
            }, false);


    $(document).on('shown.bs.modal', '#myModal', function (event) {
                const para = document.createElement("p");
    para.setAttribute("id", "para");
    if (names) {
        para.innerText = names.innerText;
    document.getElementById("myDIV").appendChild(para);
    console.log(para.innerText)
                }
    else {
                    var input = document.createElement("input");
    input.setAttribute('type', 'text');
    var parent = document.getElementById("myDIV");
    parent.appendChild(input);
                }
            });


    function removeChildEvent() {
        para = document.getElementById("myDIV")
                para.innerText = "";
};
