const editItemModal = () => {
    return(
        <form className='add-form'>
            <div className='form-control'>
                <div>
                    <label>Name</label> 
                </div>
                <input type='text' placeholder="${items.name}" required/>
            </div>
            <div className='form-control'>
                <div>
                    <label>Description</label>
                </div>
                <input type='text' placeholder="${items.description}" required/>
            </div>
            <div className='form-control'>
                <div>
                    <label>Quantity</label>
                </div>
                <input type='number' placeholder="${items.quantity}" required/>
            </div>
        </form>
    )
} 

export default editItemModal;