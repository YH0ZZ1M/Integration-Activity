const addItemModal = () => {
    return(
        <form className='add-form'>
            <div className='form-control'>
                <div>
                    <label>Name</label> 
                </div>
                <input type='text' placeholder="Add Name" required/>
            </div>
            <div className='form-control'>
                <div>
                    <label>Description</label>
                </div>
                <input type='text' placeholder="Add Description" required/>
            </div>
            <div className='form-control'>
                <div>
                    <label>Quantity</label>
                </div>
                <input type='number' placeholder="Add Quantity" required/>
            </div>
        </form>
    )
} 

export default addItemModal;