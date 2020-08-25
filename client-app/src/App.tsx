import React, {Component} from 'react';
import { Header, Icon, List } from 'semantic-ui-react';
import './App.css';
import axios from 'axios';

class App extends Component {
  state = {
    values: []
  }

  componentDidMount (){
    //axios.get('http://localhost:5000/api/values')
    //.then((response)=> {
      //console.log(response);
      //this.setState({
        //vlaues: response.data
     // })
      this.setState ({
        values: [{id:1, name: 'Sapna 101'}, {id:2 , name: 'Sonu 102'}, {id:3, name: 'Vidu 103'}]
      })
    }
    
  
  render() {
    return (
        <div >
          <Header as='h2'>
           <Icon name='users' />
           <Header.Content>ToDo</Header.Content>
            </Header>
            <List>
            {this.state.values.map((value: any) => (
                <List.Item key={value.id}>{value.name}</List.Item>
              ))}
              
              
            </List>
            
          
        </div>
  );
}
}
export default App;
