import { useEffect, useState } from 'react';
import Header from './components/Header.js';

const App = () => {
    const [isLoading, setIsLoading] = useState(true);
    const [users, setUsers] = useState([]);
    const title = "example data to pass into a prop";

    const loadUserData = async () => {
        await fetch("http://localhost:5225/api/user")
            .then(response => response.json())
            .then(data => setUsers(data));
        setIsLoading(false);
    }

    useEffect(() => {
        loadUserData();
    }, []);

    return (
        <div id="data-container">
            <Header title={title}/>
            <p style={{ display: isLoading ? 'block' : 'none' }}>your content is loading.....</p>
            {users.map(user => {
                return <div key={"user-" + user.id}>
                    <p>user: {user.name}</p>
                    <p>userId: {user.id}</p>
                    <hr></hr>
                </div>
            })}

        </div>
    )
}

export default App;
