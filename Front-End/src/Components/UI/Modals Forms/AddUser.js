const addUserModal = () => {
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
                    <label>Email</label>
                </div>
                <input type='email' placeholder="Add Email" required/>
            </div>
            <div className='form-control'>
                <div>
                    <label>Phone</label>
                </div>
                <input type='number' placeholder="Add Phone" required/>
            </div>
        </form>
    )
} 

export default addUserModal;