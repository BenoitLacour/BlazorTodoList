// Events fired on the drag target
let todoListPageObjReference = null;
export function SetTodoListPageObjReference(reference){
    todoListPageObjReference = reference;
}
document.addEventListener("dragstart", function(event) {
    event.dataTransfer.setData("todoItemId",event.target.getAttribute("data-todoItemId") ); 
});


document.addEventListener("dragover", function(event) {
    event.preventDefault();
});


/* On drop - Prevent the browser default handling of the data (default is open as link on drop)
Reset the color of the output text and DIV's border color
Get the dragged data with the dataTransfer.getData() method
The dragged data is the id of the dragged element ("drag1")
Append the dragged element into the drop element
*/
document.addEventListener("drop", function(event) {
    event.preventDefault();
    if ( event.target.className == "droptarget" ) {
        var todoItemId = event.dataTransfer.getData("todoItemId");
        console.log(todoItemId);
        todoListPageObjReference.invokeMethodAsync("Remove",todoItemId);
    }
});