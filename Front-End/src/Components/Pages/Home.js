import { Card, Container} from 'react-bootstrap';
import { Link } from 'react-router-dom';
import classes from './Home.module.css';

const Home = () =>{

    return (
        <div>
            <Container className={classes.container}>
                <Card className={classes.card}>
                    <img className={classes.image1} src="https://flyaps.com/blog/content/images/2020/05/Frame-37-2.png" alt=""></img>
                </Card>
                <Card className={classes.card}>
                    <h1> Full Stack Development!</h1>
                    <p> This website is designed to functiosen as a Web API in which it is possible to view, edit, add, and delete
                         a list of <b>Users</b> and <b>Items</b>.
                    </p>
                    <p>
                        The development of this project uses:
                            <ul>
                                <li>Boostrap, CSS and React for the <i>Front-End Development</i>.</li>
                                <li>SQLite and .Net for the <i>Back-End Development</i>.</li>
                            </ul> 
                        Feel free to explore and interact with the pages!
                    </p>
                    <div>
                        <Link to="/users" style={{color: "white", textDecoration:"none"}}><button>Users</button></Link>
                        <Link to="/items" style={{color: "white", textDecoration:"none"}}><button>Items</button></Link>
                    </div>
                </Card>
            </Container>
            
        </div>
       
    );
};

export default Home;