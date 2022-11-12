const editUserModal = () => {
    return(
        <form className='add-form'>
            <div className='form-control'>
                <div>
                    <label>Name</label> 
                </div>
                <input type='text' placeholder="${users.name}" required/>
            </div>
            <div className='form-control'>
                <div>
                    <label>Email</label>
                </div>
                <input type='email' placeholder="${users.email}" required/>
            </div>
            <div className='form-control'>
                <div>
                    <label>Phone</label>
                </div>
                <input type='number' placeholder="${users.phone}" required/>
            </div>
        </form>
    )
} 

export default editUserModal;