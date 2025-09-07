import logo from './logo.svg';
import './App.css';
import Protected from './Components/Protected';
import Login from './Components/Login';

function App() {
  return (
    <div className="App">
      <Login /> <br></br>
    <Protected />
    </div>
  );
}

export default App;
