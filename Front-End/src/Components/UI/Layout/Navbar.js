import {Fragment} from 'react';
import { Link } from 'react-router-dom';
import classes from './Navbar.module.css';

// Como hacer que la clase active vaya de acuerdo a la página en la que estás.

const Navbar = (props) => {
    return (
    <Fragment>
        <header className={classes.header}>
            <h1 className={classes.top}>Integration Activity</h1>
            <h3 className={classes.botop}> By Yhozzim Dublan</h3>
            <nav>
            <ul className={classes.ul}>
                <li className={classes.li}><Link className={classes.active} to="/home">Home</Link></li>
                <li className={classes.li}><Link to="/users">Users</Link></li>
                <li className={classes.li}><Link to="/items">Items</Link></li>
            </ul>       
            </nav>        
        </header>
        <footer className={classes.footer}> .NET/Java Academy All Rights Reserved. </footer>  
    </Fragment>
    );
};

export default Navbar;