import { Link } from 'react-router-dom';

import '../../assets/css/App';

function App() {
  return (
    <div>
      <header>
        <div>
          <Link to="/"></Link>
          <h1>colocar logo aq em cima</h1>

          <nav>
            <Link to="/">Home</Link>  
            <Link to="cliente">Livros</Link>  
            <Link to="autor">Autor</Link>  
            <Link to="adm">Adm</Link>  
            <Link to="login">Login</Link>  
          </nav>
        </div>
      </header>


    </div>
  );
}

export default App;
